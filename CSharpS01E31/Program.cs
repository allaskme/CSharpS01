using System;
using System.Diagnostics.CodeAnalysis;

namespace CSharpS01E31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 编程题1:9x9乘法表
             * 输出9x9乘法表
             */
            PrintMulti();

            /*
             * 编程题2:百钱买鸡
             * 百钱买鸡，其中公鸡、母鸡、小鸡至少买一只，公鸡3文一只，母鸡5文一只，小鸡2文一只，
             * 请问公鸡、母鸡、小鸡各买多少只正好100文
             */
            Print100ji();

            /*
             * 编程题3：最大公约数
             * 输入两个正整数num1和num2，输出这两个正整数num1和num2的最大公约数
             */
            PrintGCD();
        }

        static void PrintMulti()
        {
            Console.WriteLine("-----------编程题1:9x9乘法表------------");
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} x {i} = {i * j}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Print100ji()
        {
            Console.WriteLine("-----------编程题2:百钱买鸡------------");

            int count = 0;

            for (int i = 1; i < 33; i++)
            {
                for (int j = 1; j <= 20; j++)
                {
                    for (int k = 1; k <= 50; k++)
                    {
                        if (i * 3 + j * 5 + k * 2 == 100)
                        {
                            count += 1;
                            Console.WriteLine($"第{count}种情况：公鸡买了{i}只，母鸡买了{j}只，小鸡买了{k}只。");
                        }
                    }
                }
            }
        }

        static void PrintGCD()
        {
            //最大公约数就是能同时被两个数整除的数，肯定比两个数中最小的数要小，所以先找到最小的数，算出能整除的数，再去比较大数
            Console.WriteLine("-----------编程题3：最大公约数------------");
            Console.Write("请输入第1个数：");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入第2个数：");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int min = 0;
            if(num1 > num2)
                min = num2;
            else
                min = num1;
            
            // 倒序遍历，只要找到一个，就是最大公约数
            for(int i = min; i > 0; i--)
            {
                if(num1 % i == 0 && num2 % i == 0)
                {
                    Console.WriteLine($"最大公约数是{i}.");
                    break;
                }
            }
        }
    }
}
