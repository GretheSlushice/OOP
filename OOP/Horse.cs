using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Horse: Animal
    {
        public double maxSpeed; //måles i km/t
        private int age;

        public Horse()
        {
            Console.WriteLine("Hva hedder denne hest?");
            name = Console.ReadLine();

            Console.WriteLine("Hvilket år er hesten født?");
            birthYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hvor hurtig er den?");
            maxSpeed = Convert.ToDouble(Console.ReadLine());
        }

        private void eat()
        {
            Console.WriteLine(name + ": Gnaske gnaske...");
        }

        public void run()
        {
            age = DateTime.Today.Year - birthYear;
            if (age >= 2)
            {
                Console.Write(name+": Wrinske Wrinske med");
            }
            else
            {
                Console.Write(name+": Weeeeeeeeeeeeiiiiiiiii");
            }
            Console.WriteLine(" med " + maxSpeed + "km/t");
            Console.WriteLine(name + ": Min alder er "+age);
            eat();
        }

    }
}
