
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AspDocker3.Model;

namespace AspDocker3.Controllers
{
    //this is attribute routing
    [Route("api/[controller]")]
    public class BookController : Controller
    {

        // GET api/book
        [HttpGet]
        public IEnumerable<BooksDto> Get()
        {
            var books = new BooksDto[] {
                new BooksDto { Id = 1, Title ="book1" },
                new BooksDto { Id = 2, Title ="book2" }
            };

            return books;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
