using System;
using RPGdotnetPOO.SRC.Entities;

namespace RPGdotnetPOO
{
    class Program
    {
         static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 23, "Knight");
            Wizard Wizard = new Wizard("Jennica", 23, "white Wizard");

            Console.WriteLine(Wizard.Attack(1));  
            Console.WriteLine(Wizard.Attack(7));

        }
    }
}
