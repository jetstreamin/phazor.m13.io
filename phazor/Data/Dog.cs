using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace phazor.Data {
    public class Dog {
        [JsonProperty("message")]
        public string ImageUrl { get; set; } = "https://httpstatusdogs.com/img/404.jpg";
        public string status { get; set; }        
    }
}
