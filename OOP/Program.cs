using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //create instance of hest
            
            //Horse myHorse = new Horse();
            //1Horse myHorse2 = new Horse();

            //Cat cat = new Cat();
            //cat.name = "Molly";

            Snake snake = new Snake();
            snake.bite();
            snake.slither();

            Console.WriteLine(snake.dangerous);

            //use instance of hest
            //myHorse.run();
            //myHorse2.run();


        }
    }
}
