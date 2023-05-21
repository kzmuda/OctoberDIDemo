using System;
using System.Collections.Generic;
using System.Text;
using SuperApp;

namespace Tests
{
    public class FakeUserRepository : IUserRepository
    {
        public void AddUser(User user)
        {
        }

        public int GetX()
        {
            return 1;
        }
    }
}
