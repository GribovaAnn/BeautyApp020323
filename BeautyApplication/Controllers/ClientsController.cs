using BeautyApplication.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BeautyApplication.Controllers
{
    public class ClientsController
    {
        /// <summary>
        /// регистрация
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static bool RegClient(Clients client)
        {
            try
            {
                string jsonStr = JsonConvert.SerializeObject(client);
                var buffer = System.Text.Encoding.UTF8.GetBytes(jsonStr);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                using (HttpClient obj = new HttpClient())
                {
                    string query = $"{Manager.RootUrl}Clients";
                    HttpResponseMessage response = obj.PostAsync(query, byteContent).Result;
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
