using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace phazor.Data {
    public class Dog {
        [JsonProperty("message")]
        public string ImageUrl { get; set; } = "https://ui-ex.com/images/transparent-blue-loading-image-gif-3.gif";
        public string status { get; set; }        
    }
}
