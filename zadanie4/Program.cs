using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList big = new ArrayList();
            ArrayList newc = new ArrayList();
            ArrayList collection = new ArrayList() { 3, 'a', 8, 'B', 4.5, 'i', 55, -4, 'H', 'c', -9.01, 77, 'J', 14, 0.2};
            foreach (object o in collection)
            {

                if (o is char)
                {
                    if (char.IsUpper(Convert.ToChar(o)))
                    {
                        big.Add(o);
                    }
                }

                if (((o is int) || (o is double)))
                {
                    newc.Add(o);
                }
            }
            foreach (object o in collection)
            {
                Console.Write(o + " ");
            }
            Console.WriteLine();
            foreach (object o in newc)
            {
                Console.Write(o + " ");
            }
            Console.WriteLine();
            foreach (object o in big)
            {
                Console.Write(o + " ");
            }
            Console.ReadLine();
        }
    }
}
