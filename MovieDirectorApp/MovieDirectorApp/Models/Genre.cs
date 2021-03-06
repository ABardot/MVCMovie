﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieDirectorApp.Models
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }

        public string Type { get; set; }

        // Navigation Prop
        public virtual ICollection<Movie> Movies { get; set; }
    }
}