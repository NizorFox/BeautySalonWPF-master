using BeautySalonWPF.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonWPF.Controllers
{
    class ServicesController
    {
        public static List<Services> GetServices(int categoryId)
        {
            using (HttpClient client = new HttpClient())
            {
                string query = $"{Manager.RootUrl}Services/{categoryId}";
                Console.WriteLine(query);
                HttpResponseMessage response = client.GetAsync(query).Result;
                var content = response.Content.ReadAsStringAsync();
                var answer = JsonConvert.DeserializeObject<List<Services>>(content.Result);
                return answer;
            }
        }
    }
}
