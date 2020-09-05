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

        private readonly List<UserModel> _listUser;
        private readonly List<SatisfactionModel> _listSatisfaction;


        public SatisfationController(ILogger<SatisfationController> logger)
        {
            _logger = logger;
            _listUser = new List<UserModel>();
            _listSatisfaction = new List<SatisfactionModel>();
        }

        [HttpGet]
        [Route("GetUser")]
        public async Task<ActionResult> GetUser(string User, string Password)
        {
            try
            {
                var hash = "";

                var user = _listUser.Where(x => x.Login == User && x.Password == Password).FirstOrDefault();

                if (user != null)
                    hash = Util.CreateMD5(User + Password);


                return Ok(hash);
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
                var result = true;

                var user = _listUser.Where(x => x.Login == User.Login && x.Password == User.Login).FirstOrDefault();

                if (user != null)
                {
                    result = false;
                }
                else
                {
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(Error);
            }
        }

        [HttpGet]
        [Route("GetSatisfaction")]
        public async Task<ActionResult> GetSatisfaction(string Hash)
        {
            try
            {
                var result = Util.CreateMD5("");
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(Error);
            }
        }
        [HttpPost]
        [Route("PostSatisfaction")]
        public async Task<ActionResult> PostSatisfaction([FromBody] SatisfactionModel Satisfaction)
        {
            try
            {
                var result = Util.CreateMD5("");
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(Error);
            }
        }
    }
}
