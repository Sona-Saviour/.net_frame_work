using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Poly
    {
        public void calc()
        {
            Console.WriteLine("call the first class function");
        }
        public void calc(string a) 
        {
            Console.WriteLine("the value of a is " + a);
        
        }
        public bool calc(int b)
        {
            Console.WriteLine("enter a number");
            b=Convert.ToInt32(Console.ReadLine());
            if (b<0)
            {
                return true;
            }
            else
            {
                return false;   
            }
        }

        public int calc(int x,int y)
        {
            int pr;
            
            pr = x * y;
            return pr;
        }
        static void Main(string[] args) { 
        
        Poly p = new Poly();
        p.calc();
            Console.WriteLine("enter name");
            string s= Console.ReadLine();
       p.calc(s);
            Console.WriteLine("Enter a number");
            int x=Convert.ToInt32(Console.ReadLine());
            bool c;
            c=p.calc(x);
            Console.WriteLine("its " + c);

            Console.WriteLine("enter first num");
            int q=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second num");
            int r= Convert.ToInt32(Console.ReadLine());
            int f=p.calc(q, r);
            Console.WriteLine(f);

            //int f=p .calc(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            //Console.WriteLine(f);           
        }
    }
}
