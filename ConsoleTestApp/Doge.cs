using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestApp
{
    class Doge : Animal
    {


        public Doge(string name, int age, Sex s) : base(name, age, s)
        {

        }
       
        public override void Voice()
        {
            Console.WriteLine(name + "(" +sex.ToString() + ")" +  ": " + "bork bork");
        }
    }
}
