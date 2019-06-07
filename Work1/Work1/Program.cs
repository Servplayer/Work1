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
            Console.WriteLine("y = x^2");
            while(x<=max){
                y=Math.Pow(x,2);
                Console.WriteLine("y = " + y);
                
                x = x + ch;
                y = 0;
            }
            x=min;
            Console.WriteLine("function(x1, x2); x2=3*x1");
            while(x<=max)
            {
                //y = (Math.Pow((Math.Sin(x)), 3)+45+3*x)/(2*Math.Pow(x,4)+4*3*x); //func of 20
                //y=Math.Sqrt((Math.Pow(3*x,2)+x/(3*x))/(16*3*x*x));//var 26)
                y=Math.Sin(x - Math.Pow(3*x,3)+Math.Sqrt(x))-1.3*Math.Pow(x,3);//var27
                Console.WriteLine("y = " + y);
                sum = Math.Sin(y) + sum;
                dob = dob * y;
                x = x + ch;
                y = 0;
            }

            Console.WriteLine("Сумма синусов промежуточных значений f(x) = " + sum);
            Console.ReadKey();
        }
    }
}
