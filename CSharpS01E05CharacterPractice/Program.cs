using System;

namespace CSharpS01E05CharacterPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 练习1：得到用户输入的两个数字，然后将两个数字相加，并将和输出到控制台
            int a;
            int b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b);

            if (a < b)
            {
                Console.WriteLine(a);
            }
            else
                Console.WriteLine(b);


        }
    }
}
