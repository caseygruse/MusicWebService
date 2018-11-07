using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicWebService
{
    public class LyricData
    {
        //the annotation will let JsonDeserialise read the property as lyrics instead of the actual name.
        [JsonProperty(PropertyName = "lyrics")]
        public string Lyrics { get; set; }
    }

    
}
