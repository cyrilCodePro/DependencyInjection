using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CemasTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IPersonService _personService;
        public async Task< ActionResult> Get()
        {
            return Ok(await _personService.GetPeopleAsync());
        }
        public HomeController(IPersonService personService)
        {

        }
    }
}