using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchOnVK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter login: ");
            string login = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();
            SearchElements element = new SearchElements();
            element.Info(login, password);
        }
    }
}