using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zadanie.ViewModels.Abstract
{
    public class HeatViewModel : MediaViewModel
    {
        [JsonProperty("temperatures")]
        public List<int> Temperatures { get; set; }
    }
}
