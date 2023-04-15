
using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;

namespace EdgeJobs_Test.Models
{
    public class customtestmodel
    {
        // mantener prop como jsonNode para retornar el formato json limpio
        public JsonNode bodyjson { get; set; }
    }
}
