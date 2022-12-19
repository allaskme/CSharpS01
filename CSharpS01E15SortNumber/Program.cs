using System;

namespace CSharpS01E15SortNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());

            //if (a > b)
            //{
            //    int temp = a; a = b; b = temp;
            //}
            //if (b > c)
            //{
            //    int temp = b; b = c; c = temp;
            //}
            //if (a > b)
            //{
            //    int temp = a; a = b; b = temp;
            //}
            //Console.WriteLine(a + " " + b + " " + c);


            // 输入一个小数m和一个整数k(k只能是0或1)
            // 如果k为0，则输出m的整数部分，如果k为1，则输出m，但四舍五入保留1位小数
            // 例如
            // input：4.65 0 output：4
            // input：4.65 1 output：4.7(因为四舍五入，5要进位，且保留1位小数，则输出4.7)
            // 这个操作可以在要舍进的位+0.5，然后再*10，转换成整数，然后再除10.0转换成浮点数，这样就完成了四舍五入的转换
            double m = Convert.ToDouble(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());

            if (k == 0)
            {
                int temp = (int)m;
                Console.WriteLine(m);
            }
            if (k == 1)
            {
                double temp = ((int)((m + 0.05) * 10)) / 10.0;
                Console.WriteLine(temp);
            }

            char c = Convert.ToChar(Console.ReadLine());
            if (c >= 'a' && c <= 'z')
            {
                Console.WriteLine("你输入的是一个小写字母");
            }
            else if (c >= 'A' && c <= 'Z')
            {
                Console.WriteLine("你输入的是一个大写字母");
            }
            else if (c >= '0' && c <= '9')
            {
                Console.WriteLine("你输入的是一个数字");
            }
            else
                Console.WriteLine("你输入的是一个特殊字符");

        }
    }
}
