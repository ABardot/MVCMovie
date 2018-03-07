using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieDirectorApp.Models
{
    public class Director
    {
        [Key]
        public int DirectorID { get; set; }

        public string Name { get; set; }

        // Navigation Prop
        public virtual ICollection<Movie> Movies { get; set; }
    }
}