using System;

namespace CSharpS01E04characterVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // char类型在计算机内本质是int类型
            char a = 'a';
            int b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);

            int c = 97;
            char d = (char)c;       // 强制类型转，此处需要特别注意，可能会产生溢出，容易产生不易察觉的错误。
            Console.WriteLine(c);
            Console.WriteLine(d);

            // 转义字符，转义字符使用\，后跟需要转义的字符，常见如下：
            a = '\n';
            Console.WriteLine(a);
            a = '\\';
            Console.WriteLine(a);
            a = '\"';
            Console.WriteLine(a);
            a = '\t';
            Console.WriteLine(a);
            a = '\'';
            Console.WriteLine(a);
            a = '\a';
            Console.WriteLine(a);

            // 有时候需要单纯使用\，而不是做为转义字符使用，可以在字符串前加@，例如：
            Console.WriteLine("c:\\a\\b\\c");
            Console.WriteLine(@"c:\a\b\c");

            // 也可以用在声明字符串变量
            string strTest = @"c:\a\b\c";
            Console.WriteLine( strTest );

            // @不可用于char类型前
            char f = '\\';

            // 在字符串中，如果需要引号，可以用两个引号连着写就可以了，而不是用\"，例如：
            string strTest2 = @"test1 say:""test2";

            // 如何读取用户的输入数据，在控制台应用程序中，可以使用Console类的ReadLine()方法
            string strInput = Console.ReadLine();
            Console.WriteLine("读入的数据为：" + strInput);
            // 输入数据时，要做到两点：1、变量类型和输入数据的类型一致；2、如果不一致需要转换，要确保右边的输入值小于左边变量类型的值范围，或者使用强制类型转换以忽略
            // int a = Console.ReadLine();  //类型不一致，左边变量为int类型，右边为string类型，如果需要的话，可以改变左边的类型
            
        }
    }
}
