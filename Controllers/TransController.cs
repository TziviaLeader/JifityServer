using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using Jifity.DAL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Jifity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransController : ControllerBase
    {
        // GET: api/<TransController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TransController>/5
        [HttpGet("{id}")]
        public async Task<string> Get(int id)
        {
            var result = await ExternalApi.GetExternalResponse("/trans",id);

            return result;
        }

        // POST api/<TransController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TransController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TransController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
