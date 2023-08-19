using System;

namespace CSharpS01E20Fro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 输入一个数n,在一行内输出左中括号、n个间隔的星号和右中括号
            Console.WriteLine("输入一个数n,在一行内输出左中括号、n个间隔的星号和右中括号");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("[");
            for(int i = 0; i<n; i++)
            {
                if(i < n - 1)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("*]");
                }
            }
            Console.WriteLine();

            // 输入两个数字，计算这两个数之间能被17整除的数的和
            Console.WriteLine("输入两个数字p、q，计算这两个数之间能被17整除的数的和");
            int p = Convert.ToInt32(Console.ReadLine());
            int q = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for(int i = p;  i < q + 1; i++)
            {
                if(i % 17  == 0) {
                    Console.WriteLine(i);
                    sum += i;
                }
            }

            Console.WriteLine($"和是{sum}");

            // 输入两个正整数，利用for循环打印出来i1和i2之间（包含i1和i2，默认i1<i2），所有奇数和所有偶数，奇数放在一行，偶数放在一行，用空格分隔。
            Console.WriteLine("输入两个正整数，利用for循环打印出来i1和i2之间（包含i1和i2），所有奇数和所有偶数，奇数放在一行，偶数放在一行，用空格分隔。");

            int i1 = Convert.ToInt32(Console.ReadLine());
            int i2 = Convert.ToInt32(Console.ReadLine());
            string s1 = "";
            string s2 = "";
            for(int i = i1;  i <= i2; i++)
            {
                if (i % 2 != 0)
                {
                    if (i == i2 - 1)
                    {
                        s1 += i.ToString();
                    }
                    else { 
                        s1 += (i.ToString() + " "); 
                    }
                }
                else
                {
                    if (i == i2 - 1)
                    {
                        s2 += i.ToString();
                    }
                    else
                    {
                        s2 += (i.ToString() + " ");
                    }
                }
            }
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
