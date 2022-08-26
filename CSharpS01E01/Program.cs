using System;   // 引用的命名空间


// 初次学习
// 单行注释的组合快捷键Ctrl+k,Ctrl+C，取消Ctrl+K,Ctrl+U
// 多行注释的组合快捷键同单行注释。

namespace CSharpS01E01
{
    // 单行注释，这是Program类
    /*
     * 多行注释
     * 多行注释，VS会用*进行对齐，以方便看
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            // 单行注释
            /*
             * 多行注释
             */
            Console.WriteLine("Hello World!");  // 单行注释，可以放在语句尾部，以便查看
        }
    }
}
