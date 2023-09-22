using System;

namespace CSharpS01E34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 编程题1：冒泡排序
             */
            MaopaoSort();

            /*
             * 编程题2：检测是否是合法的标识符
             */
            IsBiaoshifu();
        }

        static void MaopaoSort()
        {
            Console.WriteLine("----------编程题1：冒泡排序--------------");
            Console.Write("请输入一组无序整数，用空格分开：");
            string s = Console.ReadLine();
            string[] sConvert = s.Split(" ");
            int[] iSConvert = new int[sConvert.Length];

            int count = 0;

            for (int i = 0; i < sConvert.Length; i++)
            {
                iSConvert[i] = Convert.ToInt32(sConvert[i].Trim());
            }

            //进行排序，轮数为数组length-1
            for (int i = 0; i < iSConvert.Length - 1; i++)
            {
                /*每轮内部循环进行数组每两个数进行比较,为了避免索引超范围，这里需要j小于数组长度-1
                 * for (int j = 0; j < iSConvert.Length - 1; j++)
                 * 第一次优化，这里可以减去j，如果不减j会对已经进行排序的数组再比较
                 * 第二次优化，增加isSwitch变量，判断有没有发生交换，如果没有发生交换说明已经是有序的
                 * 就不用再进行循环，主要是在最后几轮
                 */
                bool isSwitch = false;
                for (int j = 0; j < iSConvert.Length - 1 - i; j++)
                {
                    if (iSConvert[j] > iSConvert[j + 1])
                    {
                        int temp = iSConvert[j];
                        iSConvert[j] = iSConvert[j + 1];
                        iSConvert[j + 1] = temp;
                        isSwitch = true;
                    }
                    count++;
                }
                if (isSwitch == false)
                    break;
            }

            Console.WriteLine($"总共进行了{count}次循环");

            foreach (int i in iSConvert)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        static void IsBiaoshifu()
        {
            Console.WriteLine("---------------编程题2：检测是不是合法的标识符-------------");
            Console.Write("请输入一个字符串：");

            string s = Console.ReadLine();

            bool isBiaoshifu = true;

            if (s[0] >= '0' && s[0] <= '9')
            {
                isBiaoshifu = false;
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= '0' && s[i] <= '9') || (s[i] >= 'A' && s[i] <= 'Z') || s[i] == '_')
                        continue;
                    else
                    {
                        isBiaoshifu = false;
                        break;
                    }
                }
            }

            if (isBiaoshifu)
                Console.WriteLine($"{s}是合法标识符!");
            else
                Console.WriteLine($"{s}不是合法标识符!");


            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
