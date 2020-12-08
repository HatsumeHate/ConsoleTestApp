using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestApp
{

    public enum Sex { MALE, FEMALE }

    class Animal
    {
        protected int age { get; set; } = 1;
        protected string name { get; set; } = "No Name";
        protected Sex sex = Sex.MALE;


        public Animal() { }


        public Animal(string name, int age, Sex s)
        {
            this.age = age;
            this.name = name;
            this.sex = s;
        }

        public virtual void Voice()
        {
            Console.WriteLine(name + "(" + sex.ToString() + ")" + ": " + "bork bork");
        }

    }
}
