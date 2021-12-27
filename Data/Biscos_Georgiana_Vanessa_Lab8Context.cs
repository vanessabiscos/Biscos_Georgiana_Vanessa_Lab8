using Microsoft.EntityFrameworkCore;
using Biscos_Georgiana_Vanessa_Lab8.Models;

namespace Biscos_Georgiana_Vanessa_Lab8.Data
{
    public class Biscos_Georgiana_Vanessa_Lab8Context : DbContext
    {
        public Biscos_Georgiana_Vanessa_Lab8Context (DbContextOptions<Biscos_Georgiana_Vanessa_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }

        public DbSet<Publisher> Publisher { get; set; }

        public DbSet<Biscos_Georgiana_Vanessa_Lab8.Models.Category> Category { get; set; }
    }
}
