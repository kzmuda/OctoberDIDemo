using System;

namespace SuperApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Podaj nazwę:");
            string name = Console.ReadLine();

            Console.Out.WriteLine("Podaj email:");
            string email = Console.ReadLine();

            Console.Out.WriteLine("Podaj numer telefonu - ");
            string phoneNumber = Console.ReadLine();

            var repo = new UserRepository();

            var user = new User
            {
                Name = name,
                Email = email,
                PhoneNumber = phoneNumber
            };
            var sender = new SmsSender();
            var service = new DataService(sender);

            service.CreateUserAccount(user, repo);


            

        }
    }
}
