using FantasyPremierLeague.Models.bootstrap_static;
using FantasyPremierLeague.Models.dream_team;
using FantasyPremierLeague.Models.element_summary;
using FantasyPremierLeague.Models.entry_event_picks;
using FantasyPremierLeague.Models.entry_history;
using FantasyPremierLeague.Models.event_live;
using FantasyPremierLeague.Models.event_status;
using FantasyPremierLeague.Models.fixtures;
using FantasyPremierLeague.Models.fixtures.fixtures;
using FantasyPremierLeague.Models.leagues_classic_standings;
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
        private static readonly HttpClient _httpClient = new HttpClient() { BaseAddress = new Uri("https://fantasy.premierleague.com/api/") };

        public static async Task<BootstrapStaticRootobject> GetBootstrapStatic()
        {
            BootstrapStaticRootobject bootstrap_static;

            using (var response = await _httpClient.GetAsync($"bootstrap-static/"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                bootstrap_static = JsonConvert.DeserializeObject<BootstrapStaticRootobject>(apiResponse);
            }

            //Met endpoint property van het Rootobject
            //BootstrapStaticRootobject bootstrap_static = new BootstrapStaticRootobject();

            //using (var response = await _httpClient.GetAsync(bootstrap_static.endpoint))
            //{
            //    string apiResponse = await response.Content.ReadAsStringAsync();
            //    bootstrap_static = JsonConvert.DeserializeObject<BootstrapStaticRootobject>(apiResponse);
            //}

            return bootstrap_static;
        }

        public static async Task<DreamTeamRootobject> GetDreamTeam(int? event_id)
        {
            DreamTeamRootobject dream_team;

            using (var response = await _httpClient.GetAsync($"dream-team/{event_id}/"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                dream_team = JsonConvert.DeserializeObject<DreamTeamRootobject>(apiResponse);
            }

            return dream_team;
        }

        public static async Task<ElementSummaryRootobject> GetElementSummary(int? element_id)
        {
            ElementSummaryRootobject element_summary;

            using (var response = await _httpClient.GetAsync($"element-summary/{element_id}/"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                element_summary = JsonConvert.DeserializeObject<ElementSummaryRootobject>(apiResponse);
            }

            return element_summary;
        }

        public static async Task<EntryEventPicksRootobject> GetEntryEventPicks(int? manager_id, int? event_id)
        {
            EntryEventPicksRootobject entry_event_picks;

            using (var response = await _httpClient.GetAsync($"entry/{manager_id}/event/{event_id}/picks/"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                entry_event_picks = JsonConvert.DeserializeObject<EntryEventPicksRootobject>(apiResponse);
            }

            return entry_event_picks;
        }

        public static async Task<EntryHistoryRootobject> GetEntryHistory(int? manager_id)
        {
            EntryHistoryRootobject entry_history;

            using (var response = await _httpClient.GetAsync($"entry/{manager_id}/history/"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                entry_history = JsonConvert.DeserializeObject<EntryHistoryRootobject>(apiResponse);
            }

            return entry_history;
        }

        public static async Task<EventLiveRootobject> GetEventLive(int? event_id)
        {
            EventLiveRootobject event_live;

            using (var response = await _httpClient.GetAsync($"event/{event_id}/live/"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                event_live = JsonConvert.DeserializeObject<EventLiveRootobject>(apiResponse);
            }

            return event_live;
        }

        public static async Task<EventStatusRootobject> GetEventStatus()
        {
            EventStatusRootobject event_status;

            using (var response = await _httpClient.GetAsync($"event-status/"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                event_status = JsonConvert.DeserializeObject<EventStatusRootobject>(apiResponse);
            }

            return event_status;
        }

        public static async Task<List<Fixture>> GetFixtures(bool future_fixtures_only)
        {
            List<Fixture> fixtures;
            int x = (future_fixtures_only) ? 1 : 0;

            using (var response = await _httpClient.GetAsync($"fixtures/?future={x}"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                fixtures = JsonConvert.DeserializeObject<List<Fixture>>(apiResponse);
            }

            return fixtures;
        }

        public static async Task<FixturesRootobject> GetFixturesOfEvent(int? event_id)
        {
            FixturesRootobject fixtures;

            using (var response = await _httpClient.GetAsync($"fixtures/?event={event_id}"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                fixtures = JsonConvert.DeserializeObject<FixturesRootobject>(apiResponse);
            }

            return fixtures;
        }

        public static async Task<LeaguesClassicStandingsRootobject> GetLeaguesClassicStandings(int? league_id)
        {
            LeaguesClassicStandingsRootobject leagues_classic_standings;

            using (var response = await _httpClient.GetAsync($"leagues-classic/{league_id}/standings/"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                leagues_classic_standings = JsonConvert.DeserializeObject<LeaguesClassicStandingsRootobject>(apiResponse);
            }

            return leagues_classic_standings;
        }
    }
}
