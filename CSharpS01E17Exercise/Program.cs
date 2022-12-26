using System;

namespace CSharpS01E17Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 输入4个数，比较大小
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int max = a;
            int min = a;

            if (max < b)
            {
                max = b;
            }
            if (min < c)
            {
                max = c;
            }
            if (max < d)
            {
                max = d;
            }

            if (min > b)
            {
                min = b;
            }
            if (min > c)
            {
                min = c;
            }
            if (min > d)
            {
                min = d;
            }

            Console.WriteLine($"最大值是{max},最小值是{min}");


            // 做个简单int类型的加减乘除运算

            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine("{0} + {1} = {2}", first, second, first + second);
                    break;
                case "-":
                    Console.WriteLine("{0} - {1} = {2}", first, second, first - second);
                    break;
                case "*":
                    Console.WriteLine("{0} * {1} = {2}",first,second,first * second);
                    break;
                case "/":
                    if (second == 0)
                        Console.WriteLine("{0} / {1} 的除数为0，不能正常计算！",first,second);
                    else 
                        Console.WriteLine("{0} / {1} = {2}",first,second,(double)first /second);
                    break;
            }
        }
    }
}
