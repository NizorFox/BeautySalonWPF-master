using BeautySalonWPF.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonWPF.Controllers
{
    public static class UsersController
    {
        public static bool Auth(string login, string password)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync($"{Manager.RootUrl}Users/{login}/{password}").Result;
                return response.IsSuccessStatusCode;
            }
        }
        public static bool AddUser(Users user)
        {
            string jsonStr = JsonConvert.SerializeObject(user);
                var buffer = System.Text.Encoding.UTF8.GetBytes(jsonStr);
                var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.PostAsync($"{Manager.RootUrl}Users", byteContent).Result;
                return response.IsSuccessStatusCode;
            }
        }
    }
}
