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
            SwitchNumber();

            /*
             * 编程题4
             * 有n(n<=100)个整数，已经按照从小到大顺序排列好，现在给另外一个整数x，请将该数插入到序列中，并使新的序列仍然有序
             * 样例：
             * 23 34 45 56 67 78 89 100
             * 输入：58
             * 输出：
             * 23 34 45 56 58 67 78 89 100
             */
            InsertNumber();
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
                    if (chars[i] >= 'x' && chars[i] <= 'z' || chars[i] >= 'X' && chars[i] <= 'Z')
                    {
                        chars[i] = (char)(chars[i] - 23);
                    }
                    else
                    {
                        chars[i] = (char)(chars[i] + 3);
                    }
                }
            }

            foreach (char c in chars)
            {
                Console.Write(c);
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        static void SwitchNumber()
        {
            Console.WriteLine("--------------编程题3：交换数字--------------");
            Console.Write("请输入一组数字：");

            string input = Console.ReadLine();
            string[] strings = input.Split();
            int[] ints = new int[strings.Length];

            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = Convert.ToInt32(strings[i]);
            }

            int min = ints[0];
            int index = 0;

            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] < min)
                {
                    min = ints[i];
                    index = i;
                }
            }

            int temp = ints[0];
            ints[0] = min;
            ints[index] = temp;

            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        static void InsertNumber()
        {
            Console.WriteLine("---------------编程题4：有序数列插入数据--------------");
            Console.Write("请输入一组有序数列：");
            string str = Console.ReadLine();
            Console.Write("请输入一个要插入的数字：");
            int newNumber = Convert.ToInt32(Console.ReadLine());
            string[] strings = str.Split();
            int[] ints = new int[strings.Length];
            int[] newInts = new int[strings.Length + 1];

            int index = 0;

            //将字符数组转换为整数数组
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = Convert.ToInt32(strings[i]);
            }

            //查找位置并插入，重要的是判断！！
            if (newNumber < ints[0])
            {
                newInts[0] = newNumber;
                for (int i = 0; i < ints.Length; i++)
                {
                    newInts[i + 1] = ints[i];
                }
            }
            else if (newNumber > ints[ints.Length - 1])
            {
                for (int i = 0;i < ints.Length;i++)
                {
                    newInts[i] = ints[i];
                }
                newInts[ints.Length] = newNumber;
            }
            else
            {
                for (int i = 0; i < ints.Length; i++)
                {
                    if (ints[i] <= newNumber && newNumber <= ints[i + 1])
                    {
                        index = i + 1;
                        break;
                    }
                }

                for (int i = 0;i < index; i++)
                {
                    newInts[i] = ints[i];
                }

                newInts[index] = newNumber;

                for (int i = index; i < ints.Length; i++)
                {
                    newInts[i + 1] = ints[i];
                }
            }

            //循环输出新数组
            foreach (int i in newInts)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
