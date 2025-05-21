using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Myconsoleapp;

namespace Myconsoleapp
{
    internal class Ifcond
    {
        public void  oddeven()
        {
            Console.WriteLine("enter a number");
            int a;
            
            a = Convert.ToInt32(Console.ReadLine());
         if (a%2==0)
            {
            Console.WriteLine("even");
            }
         else
          {
            Console.WriteLine("odd");
           }

         }
    static void Main(string[] args )
     {
    Ifcond ob = new Ifcond();
    ob.oddeven();
     }
     }
}

