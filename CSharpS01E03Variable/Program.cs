using System;

namespace CSharpS01E03Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 创建变量，就是创建一个存储数据的容器
            int age;    //声明了一个名称为age的整形变量

            age = 10;   //变更的赋值

            // 常用的基本变量类型有：byte short int long float double char bool
            // 变量名区分大小写，可以是字母、数字、下划线的组合，但数字不能开头
            // 可以在一行声明多个变量，如int a = 1, b = 2

            // 练习题
            int a;
            a = 1;
            Console.WriteLine(a);
            int b = 2;
            Console.WriteLine(b);

            a = 3 + 7 - 2;
            Console.WriteLine(a);

            a = 4;
            b = 3;
            int c = 0;

            c = a;
            Console.WriteLine(c);
            c = a + b;
            Console.WriteLine(c);
            c = a - b;
            Console.WriteLine(c);
            c = a * b;
            Console.WriteLine(c);
            c = a / b;
            Console.WriteLine(c);

            char sex = 'F';
            sex = 'M';

            a = 3;
            b = 8;

            Console.WriteLine(a + b);
            Console.WriteLine("a + b");
            Console.WriteLine(a + "+" + b);
            Console.WriteLine("a + b " + a + b);
            Console.WriteLine("a + b " + (a + b));
        }
    }
}
