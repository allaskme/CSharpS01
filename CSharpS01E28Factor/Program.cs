using System;
using System.Runtime.CompilerServices;

namespace CSharpS01E28Factor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * 编程题1
             * 输入一个大于0小于1000000整数，输出该整数的因数个数和所有因数
             * 样例：9
             * 输出：
             *  因数个数为：3
             *  9的因数有：1 3 9
             */
            first();

            /*
             * 编程题2
             * 概念：因数是可以把这个数整除的数，任何一个非1正整数都至少有两个因数1和它本身。
             *      只有1和它本身两个因数的非1正整数称为质数（素数）
             *      
             * 输入一个大于1小于10000000的正整数，判断这个数是否为质数，如果是质数输出yes，不是输出no
             * 样例1：103
             * 输出：yes
             * 
             * 样例2：100
             * 输出：no
             */
            second();
        }

        static void first()
        {
            Console.Write("请输入要分析因数的整数：");
            int a = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            string output = $"{a}的因数有：";
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    count++;
                    output += i + " ";
                }
            }
            Console.WriteLine($"{a}的因数有{count}个。");
            Console.WriteLine(output);
        }
        static void second()
        {
            Console.Write("输入一个大于1小于10000000的正整数：");
            int n = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            if (n <= 1)
            {
                Console.WriteLine("请输入一个大于1的正整数！");
            }
            else
            {
                for (int i = 2; i <= (int)Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        flag = false;
                        break;
                    }
                }

                if (!flag)
                {
                    Console.WriteLine("否");
                }
                else
                {
                    Console.WriteLine("是");
                }
            }
        }
    }
}
