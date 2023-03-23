using System;

namespace CSharpS01E19WhilePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3n+1问题：对于任意⼤于1的⾃然数n，若n为奇数，将n编程3n+1，否则变成n的⼀半。经过若⼲次这样的变化，n⼀定会最终变成1，⽐如，7 → 22 → 11 → 34 → 17 → 52 → 26 → 13 → 40→ 20 → 10 → 5 → 16 → 8 → 4 →2 → 1
            // 输⼊n，输出变换的次数。
            // ⽐如输⼊3输出7 ，输⼊10，输出6

            int input = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            if (input <= 0)
            {
                Console.WriteLine("请输入一个大于0的数");
                return;
            }
            while (true)
            {
                if (input == 1)
                {
                    break;
                }
                else
                {
                    if(input % 2 == 0)
                    {
                        input /= 2;
                    }
                    else
                    {
                        input = input * 3 + 1;
                    }
                    count++;
                    Console.WriteLine($"变换后的值为{input}");
                }
            }
            Console.WriteLine($"总共变换的次数为{count}");

            // 2006年培养学员80000⼈，每年增⻓25%，请问按此增⻓速度，到哪⼀年培训学员⼈数将达到20万⼈？
            int number = 80000;
            int year = 2006;
            while (number < 200000)
            {
                Console.WriteLine($"{year}年培训了{number}名学生。");
                number = (int)(number * 1.25);
                year++;
            }
            Console.WriteLine($"{year}完成年培训20万学生的目标！");

            // 班上有若干名学生，输入学生个数n，然后输入每个学生的年龄，计算出平均年龄，保留两位小数。
            // 用代码方式保留两位小数，先乘100，用int强制转换舍小数部分，然后再除100，这个只是简易计算保留两位小数，没有考虑四舍五入的问题，另外还有其他问题。
            int stuNumber = Convert.ToInt32(Console.ReadLine());
            int temp = stuNumber;
            int sumAge = 0;
            while (temp > 0)
            {
                sumAge += Convert.ToInt32(Console.ReadLine());
                temp--;
            }
            Console.WriteLine($"输入的{stuNumber}名学生的平均年龄是{(double)(1.0 * sumAge / stuNumber)}");

            // 输⼊⼀个整数n，输出1~n中的每个数，空格隔开。
            Console.WriteLine("请输入一个要整行输出的数字");
            input= Convert.ToInt32(Console.ReadLine());
        }
    }
}
