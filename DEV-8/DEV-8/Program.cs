using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<User> users = new List<User>();
            users.Add(new User("Vasya", "Pupkin", "m", 22));
            users.Add(new User("Sasha", "Vinchevska", " m", 25));
            users.Add(new User("Lolla", "Oyri", "f", 30));
            users.Add(new User("Nastya", "Porrh", "f", 12));
            users.Add(new User("Petya", "Paas", "m", 10));
            users.Add(new User("Masha", "Baklazhan", "f", 36));
            users.Add(new User("Masha", "Tuud", "f", 25));
            users.Add(new User("Nicole", "Vjdgs", "f", 99));
            users.Add(new User("Vasya", "Rity", "m", 9));
            var avg = (from user in users select user.Age).Average();
            var max = (from user in users select user.Age).Max();
            var genderSelect = from user in users where user.Gender.Equals("f") select user;
            var groupByName = from user in genderSelect group user by user.Name into grp select new 
            {
                name = grp.Key, cnt = grp.Count()
            };
            var mostPopular = (from user in groupByName orderby user.cnt descending select user).First();
            Console.WriteLine("Average age: " + avg + " " + "\nOldest user: " + max + " " + "\nThe most popular female name: " + mostPopular);
        }
    }
}