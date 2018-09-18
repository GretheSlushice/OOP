using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Snake: Animal
    {
        public bool dangerous;

        public void bite()
        {
            Console.WriteLine("Av for satan");
        }

        public void slither()
        {
            Console.WriteLine("slither slither slither...");
        }
    }
}
