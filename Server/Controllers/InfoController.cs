﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InfoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var diff = DateTimeOffset.UtcNow - Info.Started;
            return Ok($"API started {diff.Days} days {diff.Hours} hours and {diff.Minutes} minutes ago");
        }
    }
}