﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TostTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Events : ControllerBase
    {
        // GET: api/<Events>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "GetOk" };
        }

        // GET api/<Events>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Events>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Events>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Events>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}