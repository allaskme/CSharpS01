using System;
using System.Diagnostics.CodeAnalysis;

namespace CSharpS01E31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 编程题1
             * 输出9x9乘法表
             */
            PrintMulti();

            /*
             * 编程题2
             * 百钱买鸡，其中公鸡、母鸡、小鸡至少买一只，公鸡3文一只，母鸡5文一只，小鸡2文一只，
             * 请问公鸡、母鸡、小鸡各买多少只正好100文
             */
            Print100ji();
        }

        static void PrintMulti() 
        {
            Console.WriteLine("-----------编程题1------------");
            for (int i = 1; i < 10; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} x {i} = {i*j}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Print100ji()
        {
            Console.WriteLine("-----------编程题2------------");

            int count = 0;

            for(int i = 1;i < 33;i++)
            {
                for (int j = 1;j <= 20;j++)
                {
                    for(int k = 1;k <= 50;k++)
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
    }
}
