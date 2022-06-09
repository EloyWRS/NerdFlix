using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies_MVC_6.Models.MovieViewModels
{
    public class MovieIndexData
    {
        public IEnumerable<Movie> Movies { get; set; }
        public IEnumerable<Award> Awards { get; set; }
        
    }
}
