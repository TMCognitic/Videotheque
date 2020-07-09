using System;
using System.Collections.Generic;
using System.Text;
using Videotheque.Api.Models.Client.Entities;
using Videotheque.Models.Global.Entities;

namespace Videotheque.Api.Models.Client.Mappers
{
    public static class Mappers
    {
        public static User ToGlobal(this RegisterUser user)
        {
            return new User() { LastName = user.LastName, FirstName = user.FirstName, Email = user.Email, Passwd = user.Passwd };
        }
    }
}
