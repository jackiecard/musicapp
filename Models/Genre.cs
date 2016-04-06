using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Music.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        [Index(IsUnique = true)]
        [StringLength(20, MinimumLength = 0, ErrorMessage = "The genre must have less than 20 characters")]
        public string Name { get; set; }
        public List<Album> Albums { get; set; }
    }
}