using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Movies_MVC_6.Models
{
    public class Movie
    {
        public int MovieID { get; set; }
        [Required (ErrorMessage= "Field required.Number of characters must be between 8 and 32")]
        [StringLength(32, MinimumLength =2)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Field required.Number of characters must be above 10 characters")]
        [MinLength(10)]
        public string Sinopse { get; set; }
        [Required]                     
        public string YoutubeLink { get; set; }
        [Required(ErrorMessage ="Field required. Number of characters must be between 5 and 50")]
        [StringLength(50, MinimumLength =5)]
        public string Director { get; set; }
        [Required(ErrorMessage = "Field required. Number of characters must be between 5 and 30")]
        [StringLength(30, MinimumLength = 5)]
        public string FeaturedSong { get; set; }
        [Required(ErrorMessage ="must be a decimal number.")]
        public decimal BoxOffice { get; set; }
        [MaxLength(50)]
        public string Cinematography { get; set; }
        public ICollection<MovieAward> MovieAward { get; set; }
    }
}
