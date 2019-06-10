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
            double min,max,ch,x,sum=0,y,dob=1;
            Console.WriteLine("Введите минимальное значение х");
            min=Convert.ToDouble(Console.ReadLine());
            x = min;
            Console.WriteLine("Введите максимальное значение х");
            max = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите шаг");
            ch = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("function(x1, x2); x2=3*x1");
            while(x<=max)
            {
                y=Math.Sin(x - Math.Pow(3*x,3)+Math.Sqrt(x))-1.3*Math.Pow(x,3);
                Console.WriteLine("f(x) = " + y);
                sum = Math.Sin(y) + sum;
                dob = dob * y;
                x = x + ch;
                y = 0;
            }

            Console.WriteLine("Сумма синусов промежуточных значений f(x) = " + sum);
            //part 2
            Console.WriteLine("PART 2");
            double min2, max2, x2;
            sum = 0;
            Console.WriteLine("Введите минимальные значение х1, x2");
            min = Convert.ToDouble(Console.ReadLine());
            min2 = Convert.ToDouble(Console.ReadLine());
            x = min;
            x2 = min2;
            Console.WriteLine("Введите максимальные значение х1, x2");
            max = Convert.ToDouble(Console.ReadLine());
            max2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите шаг");
            ch = Convert.ToDouble(Console.ReadLine());
            while (x <= max)
            {
                while (x2 <= max2)
                {
                    y = Math.Sin(x - Math.Pow(x2, 3) + Math.Sqrt(x)) - 1.3 * Math.Pow(x, 3);
                    Console.WriteLine("f(x) = " + y);
                    if(y>0) sum = Math.Sin(y) + sum;
                    dob = dob * y;
                    x2 = x2 + ch;
                    y = 0;
                }
                x = x + ch;
                x2 = min;
            }

            Console.WriteLine("Сумма синусов промежуточных неотрицательных значений f(x) = " + sum);
            Console.ReadKey();
        }
    }
}
