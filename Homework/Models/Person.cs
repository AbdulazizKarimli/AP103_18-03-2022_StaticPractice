using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Models
{
    internal class Person
    {
        private string _name;
        private string _surname;

        public string Name 
        { 
            get => _name; 
            set 
            { 
                if(!string.IsNullOrWhiteSpace(value) && char.IsUpper(value[0]) && value.Length >= 3 && value.Length <= 30)
                    _name = value;  
            } 
        }

        public string Surname
        {
            get => _surname;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && char.IsUpper(value[0]) && value.Length >= 3 && value.Length <= 35)
                    _surname = value;
            }
        }

        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
