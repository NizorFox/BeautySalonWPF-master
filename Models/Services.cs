using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonWPF.Models
{
    public class Services
    {
        [JsonProperty("categoryId")]
        public int ServicesCategoryId { get; set; }

        [JsonProperty("ID")]
        public int ServicesId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("cost")]
        public float Cost { get; set; }
    }
}
