using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    public class User
    {
        public static event Action<User> UserAddedEvent;

        private List<User> Users = new List<User>();

        public int Id;
        public string Name;
        public int Age;
        public Genders Gender;

        public User(int id, string name, int age, Genders gender)
        {
            Id = id;
            Name = name;
            Age = age;
            Gender = gender;
            Users.Add(this);
            UserAddedEvent?.Invoke(this);
        }
    }
     public enum Genders
    {
        Male,
        Female
    }
}
