using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWebAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class HelloController : Controller
    {
        private ILogger _logger;

        public HelloController(ILoggerFactory loggerFactory)
        {
            this._logger = loggerFactory.CreateLogger<HelloController>();
        }

        // GET: api/values
        [HttpGet]
        public string Get()
        {
            return "Hello WebAPI";
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Student student)
        {
            this._logger.LogInformation($"Student ID : {student.Id}");
            this._logger.LogInformation($"Student Name : {student.Name}");
            this._logger.LogInformation($"Student Gender : {student.Gender}");
        }
    }
}
