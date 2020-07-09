using System;
using System.Collections.Generic;
using System.Text;

using Videotheque.UI.Models.Client.Entities;
using G = Videotheque.Models.Global.Entities;

namespace Videotheque.UI.Models.Client.Mappers
{
    internal static class Mappers
    {
        internal static G.User ToGlobal(this User entity)
        {
            return new G.User() { Id = entity.Id, LastName = entity.LastName, FirstName = entity.FirstName, Email = entity.Email, Passwd = entity.Passwd };
        }

        internal static User ToClient(this G.User entity)
        {
            return new User(entity.Id, entity.LastName, entity.FirstName, entity.Email);
        }
    }
}
