﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace COT.API.Controllers
{
    [ExcludeFromCodeCoverage]
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        public TestController()
        {

        }

        [HttpGet("Index")]
        public string Index()
        {
            int a = 10;
            int b = a / 0;

            string message = "Experian COT API";
            try
            {
               
            }
            catch (Exception ex)
            {

            }
            return message;
        }
    }
}
