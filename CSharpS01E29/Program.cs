using System;

namespace CSharpS01E29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 编程题1
             * 输出一行10个*
             */
            PrintStar1();

            /*
             * 编程题2
             * 输出4行，每行10个*
             */
            PrintStar2();
        }

        static void PrintStar1()
        {
            Console.WriteLine("-------编程题1-------");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        static void PrintStar2()
        {
            Console.WriteLine("-------编程题2-------");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
