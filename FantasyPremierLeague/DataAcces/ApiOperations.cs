using FantasyPremierLeague.Models.bootstrap_static;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FantasyPremierLeague.DataAcces
{
    public static class ApiOperations
    {
        public static string baseAdress = "https://fantasy.premierleague.com/api/";

        public static async Task<BootstrapStaticRootobject> GetBootstrapStatic(HttpClient httpClient, string endpoint)
        {
            BootstrapStaticRootobject bootstrap_static;
            using (httpClient)
            {
                using (var response = await httpClient.GetAsync(baseAdress + endpoint))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    bootstrap_static = JsonConvert.DeserializeObject<BootstrapStaticRootobject>(apiResponse);
                }
            }

            return bootstrap_static;
        }
    }
}
