using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class UserBuilder
    {
        private User user;
        public UserBuilder()
        {
            user = new User();
        }
        public void SetFirstName(string name)
        {
            if (name.Equals(string.Empty))
            {
                throw new ArgumentException();
            }
            user.Name = name;
        }
        public void SetLastName(string lastName)
        {
            if (lastName.Equals(string.Empty))
            {
                throw new ArgumentException();
            }
            user.Surname = lastName;
        }
        public void SetAge(string age)
        {
            user.Age = Int32.Parse(age);
        }
        public User Build()
        {
            return user;
        }
    }
}