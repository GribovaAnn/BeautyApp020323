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
    public class ServiceCategoryesController
    {
        /// <summary>
        /// Вывод списка категорий 
        /// </summary>
        /// <returns>
        /// Коллекция из категорий
        /// </returns>
        public static List<ServiceCategoryes> GetServiceCategoryes()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"{Manager.RootUrl}ServiceCategoryes";
                Console.WriteLine(url);
                HttpResponseMessage response = client.GetAsync(url).Result;
                var content = response.Content.ReadAsStringAsync();
                var answer = JsonConvert.DeserializeObject<List<ServiceCategoryes>>(content.Result);
                return answer;
            }
        }
    }
}
