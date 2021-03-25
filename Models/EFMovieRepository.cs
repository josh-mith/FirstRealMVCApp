using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class EFMovieRepository : IMovieRepository
    {
        private MovieDbContext _context;

        public EFMovieRepository(MovieDbContext ctx)
        {
            _context = ctx;
        }

        public IQueryable<MovieResponse> Movies => _context.Movies;
    }
}
