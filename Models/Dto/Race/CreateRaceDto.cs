using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace F1_Racing_System.Models.Dto.Race
{
    public class CreateRaceDto
    {
        [Required(ErrorMessage = "Race name is required")]
        [MaxLength(20, ErrorMessage = "Race name cannot exceed 20 characters")]
        [MinLength(2, ErrorMessage = "Race name must be at least 2 characters")]
        public string Name { get; set; }
    }
}