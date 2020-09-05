using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Live.Caqui.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Live.Caqui.WebApi.Controllers
{
    [ApiController]
    [Route("Satisfation")]
    public class SatisfationController : ControllerBase
    {
        private const string Error = "Algo deu errado";
        private readonly ILogger<SatisfationController> _logger;

        public SatisfationController(ILogger<SatisfationController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("GetUser")]
        public async Task<ActionResult> GetUser(string User, string Password)
        {
            try
            {
                var result = Util.CreateMD5(User + Password);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(Error);
            }
        }
        [HttpPost]
        [Route("PostUser")]
        public async Task<ActionResult> PostUser([FromBody] UserModel User)
        {
            try
            {
                var result = Util.CreateMD5(User + Password);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(Error);
            }
        }
    }
}
