using BeautyApplication.Models;
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
        public Users GetUser(string login, string password)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = Manager.RootUrl + "Users/" + login + "/" + password;
                HttpResponseMessage response = client.GetAsync($"{url}").Result;
                var content = response.Content.ReadAsStringAsync();
                var answer = JsonConvert.DeserializeObject<Users>(content.Result);
                return answer;
            }
        }
    }
}
