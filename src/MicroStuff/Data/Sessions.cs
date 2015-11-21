using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using MicroStuff.Models;
using Newtonsoft.Json;

namespace MicroStuff.Data
{
    public interface ISessions
    {
        Task<IList<Session>> Get();
    }
    
    public class Sessions : ISessions
    {
        private readonly HttpClient _client;
        
        private readonly string _sessionsUrl;

        public Sessions()
        {
            _client = new HttpClient();
            
            var config = Startup.Configuration["SESSIONS_PORT"];
            if(string.IsNullOrEmpty(config))
            {
                _sessionsUrl = "http://localhost:5001/sessions/";
            }
            else
            {
                _sessionsUrl = $"http{config.Substring(3)}/sessions/";
            }
        }
        
        public async Task<IList<Session>> Get()
        {
            var json = await _client.GetStringAsync(_sessionsUrl);
            return JsonConvert.DeserializeObject<IList<Session>>(json);
        }
    }
}
