using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1_Racing_System.Models.Dto.Standings
{
    public class DriverStandingDto
    {
        public string DriverName { get; set; }
        public string TeamName { get; set; }
        public int TotalPoints { get; set; }
    }
}