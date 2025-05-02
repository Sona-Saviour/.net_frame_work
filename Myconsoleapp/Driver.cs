using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myconsoleapp
{
    internal class Driver
    {
        
        
        public static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.honk();
            Console.WriteLine(myCar.brand + " " + myCar.modelName);

            // Keep the console open
            Console.ReadLine();
        }
    }
}
 