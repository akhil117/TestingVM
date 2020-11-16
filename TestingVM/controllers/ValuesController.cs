using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestingVM.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }

        [HttpGet("addUser/{username}")]
        public async Task<IActionResult> GetUWConditions(string username)
        {


            var a = "encomp_usr_v2_" +username;
            System.Diagnostics.Trace.TraceInformation($"System diagnostics {a}");
            _logger.LogInformation($"Returning the result {a}");

            return new JsonResult(a);
        }
    }
}
