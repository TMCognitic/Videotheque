using System;
using System.Collections.Generic;
using System.Text;

namespace Videotheque.Api.Models.Client.Entities
{
    public class RegisterUser
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Passwd { get; set; }
    }
}
