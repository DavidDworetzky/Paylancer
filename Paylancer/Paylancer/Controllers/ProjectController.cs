using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Paylancer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        public ProjectController()
        {

        }

        [HttpPost]
        public IActionResult Add()
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult Invoices()
        {
            return Ok();
        }

        public IActionResult WorkLineItems()
        {
            return Ok();
        }
    }
}