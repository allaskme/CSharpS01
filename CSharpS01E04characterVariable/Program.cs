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
        }
    }
}
