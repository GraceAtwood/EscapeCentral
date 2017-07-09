using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EscapeCentral.Controllers
{
    [Route("api/")]
    public class RegistrationController : Controller
    {
        // POST api/values
        [HttpPost("Register")]
        public IActionResult Register([FromBody]DTOs.RegistrationRequestDTO dto)
        {

            if (dto == null)
                return BadRequest();



            return Ok();
        }
    }
}
