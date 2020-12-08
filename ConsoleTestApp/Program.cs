using System;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Doge my_doge = new Doge("Victor", 5, Sex.MALE);
            Cote my_cote = new Cote("Marsik", 7, Sex.FEMALE);

            //my_doge.NameIt("Victor", 5, Sex.MALE);
            //my_cote.NameIt("Marsik", 7, Sex.FEMALE);

            Console.WriteLine("Hello World!");

            my_doge.Voice();
            my_cote.Voice();

            Console.Read();
        }
    }
}
