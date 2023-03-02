using BeautyApplication.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
    }
}
