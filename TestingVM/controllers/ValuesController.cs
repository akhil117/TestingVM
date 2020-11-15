using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestingVM.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpGet("addUser/{username}")]
        public async Task<IActionResult> GetUWConditions(string username)
        {


            var a = "encomp_usr_" + username;
            return new JsonResult(a);
        }
    }
}
