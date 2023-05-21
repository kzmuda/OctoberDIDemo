using System;
using System.Collections.Generic;
using System.Text;

namespace SuperApp
{
    public class DataService
    {
        private ISender sender;
        // public void CreateUserAccount(
        //     string name, string email, string phoneNumber
        //     )
        // {
        //     var repo = new UserRepository();
        //     CreateUserAccount(name, email, phoneNumber, repo);
        // }

        public DataService(ISender sender)
        {
            this.sender = sender;
        }

        public void CreateUserAccount(
            User user,
            IUserRepository repo
        )
        {
            repo.AddUser(user);
            sender.Send(user.Email, "Account was created");
        }

        public void CreateUserAccount(
        )
        {
            ///
        }
    }
}
