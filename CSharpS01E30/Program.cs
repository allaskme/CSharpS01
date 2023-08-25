using System;

namespace CSharpS01E30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 编程题1
             * 输入正整数a，输出a行，每行a个*的平行四边形
             * 样例：
             * 输入：4
             * 输出：
             * ****
             *  ****
             *   ****
             *    ****
             */
            PrintStar1();

            /*
             * 编程题2
             * 输入一个正整数b，输出b层的右三角形
             * 样例：
             * 输入：5
             * 输出：
             *     *
             *    **
             *   ***
             *  ****
             * ***** 
             */
            PrintStar2();

            /*
             * 编程题3
             * 输入一个正整数c，输出c层的等腰三角形
             * 样例：4
             * 输出：
             *    *
             *   ***
             *  *****
             * ******* 
             */
            PrintStar3();

            /*
             * 编程题4
             * 输入一个正整数d，输出d层的菱形
             * 样例：
             * 输入：4
             * 输出：
             *    *
             *   ***
             *  *****
             * *******
             *  *****
             *   ***
             *    *
             */
            PrintStar4();
        }

        static void PrintStar1()
        {
            Console.WriteLine("----------编程题1-----------");
            Console.Write("请输入正整数a:");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < a; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        static void PrintStar2()
        {
            Console.WriteLine("----------编程题2-----------");
            Console.Write("输入一个正整数b:");
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= b; i++)
            {
                // n-i个空格，i个*
                for (int j = b - i; j > 0; j--)
                // for (int j = 0; j < n-i;j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        static void PrintStar3()
        {
            Console.WriteLine("----------编程题3-----------");
            Console.Write("输入一个正整数c:");
            int c = Convert.ToInt32(Console.ReadLine());

            //两种方法之一：
            //先用编程题2的方法按行输出左边三角形的每一行，然后在循环中每行追加右边的三角形，但需要每行减1操作
            for (int i = 1; i <= c; i++)
            {
                for (int j = 0; j < c - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //两种方法之二：
            //先输出每行的空格，空格数是c - i个，然后输出*，每行输出的*的个数是2*i - 1个
            for (int i = 1; i <= c; i++)
            {
                for (int j = 0; j < c - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        static void PrintStar4()
        {
            Console.WriteLine("----------编程题4-----------");
            Console.Write("输入一个正整数d:");
            int d = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= d; i++)
            {
                for (int j = 0; j <= d - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            // 倒三角形，d-1行
            // 方法1：我用的
            /*for (int i = d - 1; i >= 1; i--)
            {
                for (int j = 1; j <= d - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 2 * i - 1; j > 0; j--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }*/

            // 方法2：视频里的方法
            for (int i = 1; i <= d - 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                //d-1-i+1 = d-i
                for (int j = 0; j < (d - i) * 2 - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
