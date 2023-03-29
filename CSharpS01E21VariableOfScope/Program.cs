namespace CSharpS01E21VariableOfScope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 当前变量的都是局部变量，作用域都是在某个大括号内，父作用域的变量在子作用域使用，但子作用域的变量不能在父作用域中使用
            int a = 10;
            Console.WriteLine(a);

            if (true)
            {
                int b = 20;

                Console.WriteLine(a);
                Console.WriteLine(b); //变量b的作用域仅限在此if中

                if (true)
                {
                    int c = 30;
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
            }
            //Console.WriteLine(b);这条语句会报错，因为变量b已经超出了他们的作用域
        }
    }
}