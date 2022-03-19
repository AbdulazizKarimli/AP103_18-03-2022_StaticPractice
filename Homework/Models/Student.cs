using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Models
{
    internal class Student : Person
    {
        private int _point;

        public int Point 
        {
            get => _point; 
            set
            {
                if(value >= 0 && value <= 100)
                    _point = value;
            }
        }

        public Student(string name, int age, int point):base(name, age)
        {
            Point = point;
        }
    }
}
