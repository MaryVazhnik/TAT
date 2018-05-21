using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var users = new List<User>();
                var input = new UserBuilder();
                do
                {
                    var user = new UserBuilder();
                    Console.WriteLine("\n Input the first name:");
                    user.SetFirstName(Console.ReadLine());
                    Console.WriteLine("\n Input the surname:");
                    user.SetLastName((Console.ReadLine()));
                    Console.WriteLine("\n Input the age:");
                    user.SetAge(Console.ReadLine());
                    users.Add(user.Build());
                    Console.WriteLine("\nFor continue input press k");
                }
                while (Console.ReadKey(true).KeyChar == 'k');
                var avg = (from user in users select user.Age).Average();
                var max = (from user in users select user.Age).Max();
                var min = (from user in users select user.Age).Min();
                Console.WriteLine("Average age: " + avg + " " + "\nOldest user: " + max + " " + "\nYoungest user: " + min);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}