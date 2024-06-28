using Newtonsoft.Json;
using System.Collections.Generic;


namespace Vestillo.IDFace.Entidade
{
    public class Action
    {
        [JsonProperty("action")]
        public string ActionName { get; set; }
        [JsonProperty("parameters")]
        public string Parameters { get; set; }
    }

    public class Result
    {
        [JsonProperty("event")]
        public int Event { get; set; }
        public int user_id { get; set; }
        public string user_name { get; set; }
        public bool user_image { get; set; }
        public string message { get; set; }
        public int portal_id { get; set; }
        public List<Action> actions { get; set; }
    }

    public class Root
    {
        public Result Result { get; set; }
    }

}
