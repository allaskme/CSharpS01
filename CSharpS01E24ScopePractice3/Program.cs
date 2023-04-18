namespace CSharpS01E24ScopePractice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 输入一个整数a，和一个正整数n，计算a的n次方
            int a = Convert.ToInt32 (Console.ReadLine());
            int n = Convert.ToInt32 (Console.ReadLine());
            int loop = n;
            int sum = 1;

            while(loop > 0)
            {
                sum *= a;
                loop--;
            }
            Console.WriteLine ($"{a}的{n}次方是{sum}");

            // 输入一个正整数n，求n的阶乘

            n = Convert.ToInt32 (Console.ReadLine());

            int factorial = Factorial(n);
            Console.WriteLine($"{n}的阶乘是{factorial}");
        }

        // 递归函数
        static public int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}