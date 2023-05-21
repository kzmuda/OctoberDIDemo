using System;
using System.Collections.Generic;
using System.Text;

namespace SuperApp
{
    public class SmsSender : ISender
    {
        public void Send(string phoneNumber, string text)
        {
            Console.Out.WriteLine($"SMS was send to {phoneNumber}");
        }
    }
}
