using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
   public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public User() { }
        public User(string Name, string Surname, string Gender, int Age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Gender = Gender;
            this.Age = Age;
        }
        public void GetInfo()
        {
            Console.WriteLine(this.Name + " " + this.Surname + " " + 
                              this.Gender + " " + this.Age);
        }
    }
}