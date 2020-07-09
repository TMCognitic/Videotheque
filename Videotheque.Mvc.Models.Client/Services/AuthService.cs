using System;
using System.Collections.Generic;
using System.Text;
using Videotheque.Models.Interfaces;
using Videotheque.UI.Models.Client.Entities;
using Videotheque.UI.Models.Client.Mappers;
using G = Videotheque.Models.Global.Entities;

namespace Videotheque.UI.Models.Client.Services
{
    public class AuthService : IAuthService<User>
    {
        IAuthService<G.User> _globalService;

        public AuthService(IAuthService<G.User> globalService)
        {
            _globalService = globalService;
        }


        public void Register(User user)
        {
            _globalService.Register(user.ToGlobal());
        }
    }
}
