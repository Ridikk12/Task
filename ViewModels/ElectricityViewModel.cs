using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zadanie.ViewModels
{
    public class ElectricityViewModel : MediaViewModel
    {
		[JsonConverter(typeof(StringEnumConverter))]
		[JsonProperty("houseType")]
        public HouseType HouseType { get; set; }



    }
}
