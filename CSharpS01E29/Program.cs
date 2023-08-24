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

            /*
             * 编程题3
             * 输入两个整数m和n，输出m行n列的*阵
             */
            PrintStar3();


            /*
             * 编程题4
             * 输入整数n，输出n行，每行n个*的星形三角形
             * 样例：
             * 输入：3
             * 输出：
             * *
             * **
             * ***
             */
            PrintStar4();

            /*
             * 编程题5
             * 输入整数k，输出k行三角形的斜边
             * 样例：
             * 输入：5
             * 输出：
             * *
             *  *
             *   *
             *    *
             *     *
             */
            PrintStar5();

            /*
             * 编程题6
             * 输入整数x，输出x行三角形的斜边，但输出与题5相反
             * 样例：
             * 输入：5
             * 输出：
             *     *
             *    *
             *   *
             *  *
             * *
             */
            PrintStar6();
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
            Console.WriteLine();
            Console.WriteLine();
        }

        static void PrintStar3()
        {
            Console.WriteLine("-------编程题3-------");
            Console.Write("请输入行数m:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入列数n:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void PrintStar4()
        {
            Console.WriteLine("-------编程题4-------");
            Console.Write("请输入行列数n:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void PrintStar5()
        {
            Console.WriteLine("-------编程题5-------");
            Console.Write("请输入行列数k:");
            int k = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= k; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        static void PrintStar6()
        {
            Console.WriteLine("-------编程题6-------");
            Console.Write("请输入行列数x:");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = x; i >= 1; i--)
            {
                for (int j = i - 1; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
