using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Zadanie.ViewModels
{
    public abstract class MediaViewModel
    {
        [JsonProperty("price")]
        public double Price { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }

    }
}
