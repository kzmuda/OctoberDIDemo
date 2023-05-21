using System;
using System.Collections.Generic;
using System.Text;

namespace SuperApp
{
    public interface ISender
    {
        void Send(string email, string text);
    }

    public class EmailSender : ISender
    {
        public void Send(string email, string text)
        {
            Console.Out.WriteLine($"Mail was send to {email}");
        }
    }
}
