using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Music.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        [Range(0, 20, ErrorMessage = "Name should have less than 20 characters")]
        public string Name { get; set; }
        public List<Album> Albums { get; set; }
    }
}