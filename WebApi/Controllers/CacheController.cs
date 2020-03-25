using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using StackExchange.Redis;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]    
    public class CacheController : ControllerBase
    {
        private readonly IDatabase redisdb;
        private readonly IConfiguration configuration;

        public CacheController(IDatabase redisdb, IConfiguration configuration)
        {
            this.redisdb = redisdb;
            this.configuration = configuration;
        }


        [HttpGet]        
        public string EnvironmentConnection()
        {
            return $"{configuration.GetSection("REDIS_CONN").Value}";
        }

        [HttpGet]        
        public string Ping() 
        {           
            var result = redisdb.Execute("PING").ToString();
            return $"PING : {result}";
        }

        [HttpPost]
        public void SetRedisData(KeyValuePair<string, string> data)
        {
            redisdb.StringSet(data.Key, data.Value, TimeSpan.FromSeconds(120));
        }

        [HttpGet]
        public string GetRedisData(string key)
        {
            return redisdb.StringGet(key);
        }
    }
}