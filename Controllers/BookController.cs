
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AspDocker3.Model;
using AspDocker3.Data;
using System.Threading.Tasks;

namespace AspDocker3.Controllers
{
    //this is attribute routing
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private readonly BookContext context;

        public BookController(BookContext context)
        {
            this.context = context;
        }

        // GET api/book
        [HttpGet]
        public async Task<IEnumerable<BooksDto>> Get()
        {
            return await this.context.Books.ToListAsync();
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
