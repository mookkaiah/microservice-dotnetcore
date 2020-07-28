using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mathservice.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ArithmaticController : ControllerBase
    {
        [HttpGet]
        [Route("/Arithmatic")]
       
        public IActionResult Get()
        {
            return Ok("Hi, I am Arithmatic controller");
        }

        [HttpGet]
        [Route("/Arithmatic/Add")]
        [Route("/Arithmatic/Add/{b}")]
        public IActionResult Add(int b)
        {
            if(  b == 0)
                b = 10;

            int a = 10;
            return Ok(a + b);
        }
    }
}
