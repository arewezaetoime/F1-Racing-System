﻿using F1_Racing_System.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace F1_Racing_System.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        public TeamsController()
        {

        }


        [HttpGet]
        public async Task<IActionResult> GetAllTeams()
        {
            var allTeamsDomainModel = await AppDbContext.Teams.ToListAsync();
        }
    }
}
