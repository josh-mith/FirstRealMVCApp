using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public interface IMovieRepository
    {
        //Get movie objects from SeedData and store in an array
        IQueryable<MovieResponse> Movies { get; }
    }
}
