using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApi
{
    public class LoginUserDTO
    {
        [JsonProperty("token")]
        public string TokenByProperty { get; set; }
    }
}
