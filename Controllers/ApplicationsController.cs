﻿using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Net.Http.Headers;
using Jifity.DAL;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Jifity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class applicationsController : ControllerBase
    {

        // GET: api/<applicationsController>
        [HttpGet]
        public async Task<string> Get()
        {
            var result = await ExternalApi.GetExternalResponse("/applications",null);

            return result;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
