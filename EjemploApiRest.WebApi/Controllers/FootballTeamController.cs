﻿using EjemploApiRest.Application;
using EjemploApiRest.Entities;
using EjemploApiRest.WebApi.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploApiRest.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballTeamController : ControllerBase
    {
        readonly IApplication<FootballTeam> _football;
        public FootballTeamController(IApplication<FootballTeam> football)
        {
            _football = football;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_football.GetAll());
        }


        [HttpPost]
        public IActionResult Save (FootballTeamDTO dto )
        {
            var f = new FootballTeam()
            {
                Name = dto.Name,
                Score = dto.Score,
                Manager = dto.Manager
            };

            return Ok(_football.Save(f));
        }
    }
}
