using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Videotheque.Api.Models.Client.Entities;
using Videotheque.Api.Models.Client.Mappers;
using Videotheque.Models.Global.Entities;
using Videotheque.Models.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Videotheque.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthService<User> _authService;
        public AuthController(IAuthService<User> authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [Route("register")]
        public void Register(RegisterUser registerUser)
        {
            _authService.Register(registerUser.ToGlobal());
        }
    }
}
