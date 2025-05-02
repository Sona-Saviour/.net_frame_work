using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myconsoleapp
{
    internal class Myclass
    {
        int a;
        int b;
        int c;
        public Myclass()
        {
            Console.WriteLine("My Constructor");
            a = 10;
            b = 20;
        }
        public void Add()
        {
            c = a + b;
            Console.WriteLine("The sum is " + c);
        }
       
    }
}
