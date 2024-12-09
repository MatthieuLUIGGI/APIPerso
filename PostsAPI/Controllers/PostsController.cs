using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PostsAPI.Tools;

namespace PostsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Posts> Get()
        {
            Posts joke = new Posts();
            Call call = new Call();
            var result = call.GetPosts("https://jsonplaceholder.typicode.com/posts/5");
            yield return result;


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
