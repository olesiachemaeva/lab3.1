using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            String age_string = "";
            Console.WriteLine("Ведите возраст");
            age = Convert.ToInt32(Console.ReadLine());
            if (age < 20 || age > 69)
                Console.WriteLine("Возраст должен быть от 20 до 69..");
            else
            {
                if (age < 30)
                    age_string += "двадцать ";
                else if (age < 40)
                    age_string += "тридцать ";
                else if (age < 50)
                    age_string += "сорок ";
                else if (age < 60)
                    age_string += "пятьдесят ";
                else
                    age_string += "шестьдесят ";
                switch (age % 10)
                { case 1: age_string += "один "; break;
                    case 2: age_string += "два "; break;
                    case 3: age_string += "три "; break;
                    case 4: age_string += "четыре "; break;
                    case 5: age_string += "пять "; break;
                    case 6: age_string += "шесть "; break;
                    case 7: age_string += "семь "; break;
                    case 8: age_string += "восемь "; break;
                    case 9: age_string += "девять "; break;
                }
                age_string += age % 10 == 0 || age % 10 > 4 ? "лет" : (age % 10 == 1 ? "год" : "года");
                Console.WriteLine(age_string);
            }
            Console.ReadKey();
        }
    }
}
