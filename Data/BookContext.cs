using Microsoft.EntityFrameworkCore;
using AspDocker3.Model;

namespace AspDocker3.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
           
        }

        public DbSet<BooksDto> Books
        {
            get;
            set;
        }

    }
}
