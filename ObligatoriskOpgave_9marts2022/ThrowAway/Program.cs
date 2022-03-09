using System;

namespace ThrowAway
{
    class Program
    {
        static void Main(string[] args)
        {
            ObligatoriskOpgave_9marts2022.Car carl = new ObligatoriskOpgave_9marts2022.Car("Volvo", 10000, "ub 48");
            ObligatoriskOpgave_9marts2022.Car bob = new ObligatoriskOpgave_9marts2022.Car("Buick", 9293, "ja 321");

            

            ObligatoriskOpgave_9marts2022.Car hej = new ObligatoriskOpgave_9marts2022.Car("sdfsfasdgfgdfgdf", 69, "dafa");

            Console.WriteLine(carl.Id);
            Console.WriteLine(bob.Id);
            Console.WriteLine(hej.Id);
            Console.WriteLine();

         
        }
    }
}
