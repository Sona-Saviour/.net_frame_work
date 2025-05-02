using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymorphism;



namespace Polymorphism
{
    abstract class Shape
    {
        public abstract void area(int r); // Abstract method with parameter

        public void showdata()
        {
            Console.WriteLine("Show Function");
        }
    }

    class Circle : Shape
    {
        public override void area(int r)
        {
            const double pi = 3.14;
            double ar = pi * r * r;
            Console.WriteLine("Area of Circle = " + ar);
        }
    }

    internal class Abstracts
    {
        public static void Main(string[] args)
        {
            Circle c = new Circle();

            Console.WriteLine("Enter radius:");
            int ra = Convert.ToInt32(Console.ReadLine());

            c.area(ra);      // Pass radius to area method
            c.showdata();    // Call the base class method
        }
    }
}





