using System;
using System.Collections.Generic;
using System.Text;

namespace SuperApp
{
    public class SmsSender
    {
        public void SendSms(string phoneNumber, string text)
        {
            Console.Out.WriteLine($"SMS was send to {phoneNumber}");
        }
    }
}
