using Newtonsoft.Json;
using System.Collections.Generic;

namespace WindowsFormsApp1.Models
{
    public class Characters
    {

        public Info Info { get; set; }

        [JsonProperty("results")]
        public List<Character> Results { get; set; }

    }
}
