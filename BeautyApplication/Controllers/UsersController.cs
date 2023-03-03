using BeautyApplication.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BeautyApplication.Controllers
{
    public  class UsersController
    {
        /// <summary>
        /// Авторизация
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns>
        /// Объект класса Users
        /// </returns>
        public static Users GetUser(string login, string password)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = Manager.RootUrl + "Users/" + login + "/" + password;
                    Console.WriteLine(url);
                    HttpResponseMessage response = client.GetAsync($"{url}").Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var content = response.Content.ReadAsStringAsync();
                        var answer = JsonConvert.DeserializeObject<Users>(content.Result);
                        return answer;
                    }
                    else { return null; }
                }
            }
            catch
            {
                throw new Exception("Ошибка подключения к серверу");
            }     
        }
        /// <summary>
        /// регистрация
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool RegUser(Users user)
        {
            try
            {
                string jsonStr = JsonConvert.SerializeObject(user);
                var buffer = System.Text.Encoding.UTF8.GetBytes(jsonStr);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                using (HttpClient client = new HttpClient())
                {
                    string query = $"{Manager.RootUrl}Users";
                    HttpResponseMessage response = client.PostAsync(query, byteContent).Result;
                    return response.IsSuccessStatusCode;
                }
            }
            catch
            {
                throw new Exception("Ошибка подключения к серверу");
            }
        }


    }
}
