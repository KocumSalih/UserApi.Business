using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserApi.Business.Abstract;
using UserApi.Entities;

namespace UserApi.Api.Controllers
{
    [Route("test")]
    [ApiController]
    public class TestController : ControllerBase
    {
        IUserBusiness _userBusiness;

        public TestController(IUserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }

        [HttpPost("SaveUser")]
        public async Task<IActionResult> SaveUser([FromBody] User user)
        {
            IActionResult result=null;

            if (user != null)
            {
                _userBusiness.SaveUser(user);
                result = Ok();
            }
            else
            {
                result = BadRequest();
            }

           return result;
        }
    }
}
