using Microsoft.EntityFrameworkCore;
using SimbirSoft_Appl.Models;

namespace SimbirSoft_Appl.DataLists
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<BookDto> Books { get; set; }
    }
}
