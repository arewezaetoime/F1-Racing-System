﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace F1_Racing_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        public TeamsController()
        {
            
        }


        [HttpGet]

        public async Task<IActionResult> GetAllTeams()
        {

        }
    }
}
