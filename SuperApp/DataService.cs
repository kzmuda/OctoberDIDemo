using System;
using System.Collections.Generic;
using System.Text;

namespace SuperApp
{
    public class DataService
    {
        // public void CreateUserAccount(
        //     string name, string email, string phoneNumber
        //     )
        // {
        //     var repo = new UserRepository();
        //     CreateUserAccount(name, email, phoneNumber, repo);
        // }

        public void CreateUserAccount(
            string name, string email, string phoneNumber,
            IUserRepository repo
        )
        {


            var user = new User
            {
                Name = name,
                Email = email,
                PhoneNumber = phoneNumber
            };

            repo.AddUser(user);
            
        }
    }
}
