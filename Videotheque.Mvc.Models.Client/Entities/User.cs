using System;
using System.Collections.Generic;
using System.Text;

namespace Videotheque.UI.Models.Client.Entities
{
    public class User
    {
        private int _id;
        private string _lastName, _firstName, email, passwd;

        public int Id
        {
            get
            {
                return _id;
            }

            private set
            {
                _id = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }

            private set
            {
                _lastName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }

            private set
            {
                _firstName = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            private set
            {
                email = value;
            }
        }

        public string Passwd
        {
            get
            {
                return passwd;
            }

            private set
            {
                passwd = value;
            }
        }

        public User(string lastName, string firstName, string email, string passwd)
        {
            LastName = lastName;
            FirstName = firstName;
            Email = email;
            Passwd = passwd;
        }

        internal User(int id, string lastName, string firstName, string email)
            : this (lastName, firstName, email, null)
        {
            Id = id;
        }
    }
}
