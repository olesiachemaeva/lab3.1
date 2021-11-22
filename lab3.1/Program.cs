using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, x3, x4, y1, y2, y3, y4;
            Console.Write("х1-");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("y1-");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("х2-");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("y2-");
            y2 = int.Parse(Console.ReadLine());
            Console.Write("х3-");
            x3 = int.Parse(Console.ReadLine());
            Console.Write("y3-");
            y3 = int.Parse(Console.ReadLine());
                       x4 = x1;
                y4 = y3;

            if(x1==x2)
            {
                if (y3 == y2)
                {
                    y4 = y1;
                    x4 = x3;
                }
                else if (y3 == y1)
                {
                    x4 = x3;
                    y4 = y2;
                }
                else Console.WriteLine("Не параллельны");
            }
            else if(x2==x3)
            {
                if (y3 == y2)
                {
                    x4 = x1;
                    y4 = y1;
                }
                else if (y3 == y1)
                {
                    x4 = x1;
                    y4 = y2;
                }
                else Console.WriteLine();
            }
            else if(x1==x3)
            {
                if (y3 == y2)
                {
                    x4 = x2;
                    y4 = y1;
                }
                else if (y3 == y1)
                {
                    x4 = x2;
                    y4 = y2;
                }
                else Console.WriteLine("Не параллельны");
            }
            else Console.WriteLine("Не параллельны");

            Console.WriteLine(x1 + "\t" + y1);
            Console.WriteLine(x2 + "\t" + y2);
            Console.WriteLine(x3 + "\t" + y3);
            Console.WriteLine(x4 + "\t" + y4);
            Console.ReadLine();
        }
    }
}
