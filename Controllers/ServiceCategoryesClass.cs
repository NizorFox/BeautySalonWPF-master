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
    public class ServiceCategoryesClass
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<ServiceCategoryes> GetServiceCategoryes()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync($"{Manager.RootUrl}ServiceCategoryes").Result;
                var content = response.Content.ReadAsStringAsync();
                var answer = JsonConvert.DeserializeObject<List<ServiceCategoryes>>(content.Result);
                return answer;
            }
        }
        public static ServiceCategoryes GetInfoCategoryes(int idCat)
        {
            return GetServiceCategoryes().Where(x => x.CategoryId == idCat).FirstOrDefault();
        }
    }
}
