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

            var service = new DataService();
            service.CreateUserAccount(name, email, phoneNumber, repo);


            

        }
    }
}
