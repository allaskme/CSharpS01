using System;

namespace CSharpS01E33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 编程题1
             * 3个空可乐瓶可以换1瓶新可乐，现在有364瓶可乐，问一共可以喝多少瓶可乐，还剩下几个空瓶
             */
            MayDrinkCola();

            /*
             * 编程题2
             * 编写一个应用程序用来对输入的字符串进行加密（只对字母加密，不对其他字符加密），对于字母字符串的加密
             * 规则如下：
             * a->d，b->e，w->z……x->a，y->b，z->c，A->D，B->E……W->Z，X->A，Y->B，Z->C
             */
            EncryptChar();

            /*
             * 编程题3
             * 输入n(n<100)个数，找出其中最小的数，将它与最前面的数交换后输出这些数
             * 样例：
             * 23 23 23 45 56 213 4 5
             */

        }

        static void MayDrinkCola()
        {
            Console.WriteLine("--------------编程题1：可以喝多少瓶可乐--------------");
            int sourceColaNumber = 364;
            int drinkColaNumber = 364;

            while (sourceColaNumber > 2)
            {
                drinkColaNumber += sourceColaNumber / 3;
                sourceColaNumber = sourceColaNumber % 3 + sourceColaNumber / 3;
            }

            Console.WriteLine($"总共喝了{drinkColaNumber},还剩下{sourceColaNumber}");

            Console.WriteLine();
            Console.WriteLine();
        }

        static void EncryptChar()
        {
            Console.WriteLine("----------------编程题2:字符串循环加密--------------------");
            Console.Write("请输入要加密的字符串：");
            string source = Console.ReadLine();
            char[] chars = source.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] >= 'a' && chars[i] <= 'z' || chars[i] >= 'A' && chars[i] <= 'Z')
                {
                    if (chars[i] >= 'x' && chars[i] <= 'z'|| chars[i] >= 'X' && chars[i] <= 'Z')
                    {
                        chars[i] = (char)(chars[i] - 23);
                    }
                    else
                    {
                        chars[i] = (char)(chars[i] + 3);
                    }
                }
            }

            foreach(char c in chars)
            {
                Console.Write(c);
            }
        }

        static void SwitchNumber()
        {
            Console.WriteLine("--------------编程题3：交换数字--------------");
        }
    }
}
