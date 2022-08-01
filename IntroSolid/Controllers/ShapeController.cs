using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntroSolid.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntroSolid.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShapeController : ControllerBase
    {
        private readonly ILogger<ShapeController> _logger;

        public ShapeController(ILogger<ShapeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]

        public string Get(string shape) => new ShapeTranslator().ResolveShape(shape).Draw();
        
    }
}
