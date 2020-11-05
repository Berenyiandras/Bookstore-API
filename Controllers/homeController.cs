using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore_API.Contracts;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bookstore_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class homeController : ControllerBase
    {
        private readonly ILoggerService _logger;

        public homeController(ILoggerService logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // GET: api/<homeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            
            _logger.LogInfo("Accessed home controlloer ");
            return new string[] { "value1", "value2" };
        }

        // GET api/<homeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            
            _logger.LogDebug("Get/id accessed");
            return "value";
        }

        // POST api/<homeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            _logger.LogDebug("Post accessed");
        }

        // PUT api/<homeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            _logger.LogDebug("PUT accessed");
        }

        // DELETE api/<homeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _logger.LogDebug("Delete accessed");
        }
    }
}
