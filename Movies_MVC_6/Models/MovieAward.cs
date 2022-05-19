using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Movies_MVC_6.Models
{
    public class MovieAward
    {
        public int MovieAwardID { get; set; }
        public int MovieID { get; set; }        
        public int AwardID { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual Award Award { get; set; }

    }
}
