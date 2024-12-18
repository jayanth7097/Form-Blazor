using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Form.Models
{
    public class UserDetails
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public bool IsSubscribed { get; set; }

        [Required]
        public string Gender { get; set; } // Radio Button: Male, Female, Other

        [Required]
        public string Country { get; set; } // Dropdown: Country List

        public double Rating { get; set; } // Slider for rating (e.g., 1–10)

        public bool WantsStereo { get; set; } // Checkbox: Stereo system

        [Required]
        public string PreferredTime { get; set; } // Radio Button: Morning, Afternoon, Evening

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}