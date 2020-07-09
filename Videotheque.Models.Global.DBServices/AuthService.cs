using System;
using Tools.Database;
using Videotheque.Models.Global.Entities;
using Videotheque.Models.Interfaces;

namespace Videotheque.Models.Global.DBServices
{
    public class AuthService : IAuthService<User>
    {
        private IConnection _connection;
        public AuthService(IConnection connection)
        {
            _connection = connection;
        }

        public void Register(User user)
        {
            Command command = new Command("AppUser.CSP_Register", true);
            command.AddParameter("LastName", user.LastName);
            command.AddParameter("FirstName", user.FirstName);
            command.AddParameter("Email", user.Email);
            command.AddParameter("Passwd", user.Passwd);

            _connection.ExecuteNonQuery(command);
        }
    }
}
