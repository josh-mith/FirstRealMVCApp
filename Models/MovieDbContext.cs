using Microsoft.EntityFrameworkCore;
using Assignment3.Models;

namespace Assignment3.Models
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options)
            : base(options) 
        { 
        
        }
        public DbSet<MovieResponse> Movies { get; set; }
    }
}
