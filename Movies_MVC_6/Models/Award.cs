using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Movies_MVC_6.Models
{
    public class Award
    {
        public int AwardID { get; set; }
        [Required (ErrorMessage ="Field required. Number of characters must be between 8 and 32")]
        [StringLength(32, MinimumLength= 8)]        
        public string Type { get; set;}
        public ICollection<MovieAward> MovieAward { get; set; }
    }
}
