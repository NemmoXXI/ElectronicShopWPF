using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicShopYamukov.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }

        public string Email { get; set; }
        public string Login { get; set; }

        public string Password { get; set; }

        public UserEntity() { }

        public UserEntity(
            string email,
            string login,
            string password)
        {
            Email = email;
            Login = login;
            Password = password;
        }
    }
}
