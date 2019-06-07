using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1
{
    class Program
    {
        static void Main(string[] args)
        {
            double min,max,ch,x,sum=0,y;
            Console.WriteLine("Введите минимальное значение х");
            min=Convert.ToDouble(Console.ReadLine());
            x = min;
            Console.WriteLine("Введите максимальное значение х");
            max = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите шаг");
            ch = Convert.ToInt32(Console.ReadLine());
            while(x<=max)
            {
                y = (Math.Pow((Math.Sin(x)), 3)+45+3*x)/(2*Math.Pow(x,4)+4*3*x); //func of 20
                Console.WriteLine("y = " + y);
                sum = y + sum;
                x = x + ch;
                y = 0;
            }

            Console.WriteLine("Сумма промежуточных у = " + sum);
            Console.ReadKey();
        }
    }
}
