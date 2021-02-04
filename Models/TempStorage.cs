using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class TempStorage
    {
        private static List<MovieResponse> submissions = new List<MovieResponse>();

        public static IEnumerable<MovieResponse> Submissions => submissions;

        public static void AddSubmission(MovieResponse submission)
        {
            submissions.Add(submission);
        }
    }
}
