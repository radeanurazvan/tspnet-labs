using System;
using System.ComponentModel.DataAnnotations;

namespace Lab11.Razor.Models
{
    public class Track
    {
        public Track()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        public string Title { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        public string Artist { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        public string Album { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public TimeSpan Duration { get; set; }

        [DataType(DataType.Date)]
        [Display(Name="Release Date")]
        public DateTime ReleaseDate { get; set; }
    }
}