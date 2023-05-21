using System;
using System.Collections.Generic;
using System.Text;

namespace SuperApp
{
    public class EmailSender
    {
        public void SendEmail(string email, string text)
        {
            Console.Out.WriteLine($"Mail was send to {email}");
        }
    }
}
