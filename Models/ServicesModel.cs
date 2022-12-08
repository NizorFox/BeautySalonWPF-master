using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonWPF.Models
{
    class ServicesModel
    {
        [JsonProperty("CategoryId")]
        public int ServicesCategoryId { get; set; }

        [JsonProperty("ID")]
        public int ServicesId { get; set; }

        [JsonProperty("Title")]
        public string ServicesTitle { get; set; }

        [JsonProperty("Cost")]
        public int ServicesCost { get; set; }
    }
}
