namespace CSharpS01E24ScopePractice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 输入一个整数a，和一个正整数n，计算a的n次方
            /*Console.WriteLine("计算a的n次方");
            int a = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int loop = n;
            int sum = 1;

            while (loop > 0)
            {
                sum *= a;
                loop--;
            }
            Console.WriteLine($"{a}的{n}次方是{sum}");

            // 输入一个正整数n，求n的阶乘
            Console.WriteLine("计算输入n的阶乘");
            n = Convert.ToInt32(Console.ReadLine());

            int factorial = Factorial(n);
            Console.WriteLine($"{n}的阶乘是{factorial}");*/


            // 输入一个整数q和n,求公式1+q(的一次方) + q(的二次方) + …… + q(的n次方)
            Console.WriteLine("1+q(的一次方) + q(的二次方) + …… + q(的n次方)");
            int q = Convert.ToInt32(Console.ReadLine());
            int temp = 1;
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for(int i = 1;i <= n; i++)
            {
                for(int j = 1 ;j <= i ; j++ )
                {
                    temp *= q;
                }
                sum += temp;
                temp = 1;
            }
            sum += 1;
            Console.WriteLine($"1+{q}(的一次方) + {q}(的二次方) + …… + {q}(的{n}次方)的和是{sum}");

            // 已知：Sn = 1 + 1/2 + 1/3 + ... + 1/n。 显然对于任意⼀个整数k，当n⾜够⼤的时候，Sn⼤于K。
            // 现输⼊⼀个整数K（1≤K≤15），要求计算出⼀个最⼩的n，使得Sn > K。
            // 输⼊⼀个整数K，输出⼀个整数n。

            n = 1;
            int k = Convert.ToInt32(Console.ReadLine());
            double sn = 1.0;

            while(sn <= k)
            {
                sn += 1.0 / n;
                n++;
            }
            Console.WriteLine($"n = {n-1}后，{sn}>{k}");

            // 我国现有x亿⼈⼝，按照每年0.1 % 的增⻓速度，n年后将有多少⼈？
            double x = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1;i <= n;i++)
            {
                x *= 1.001;
            }
            Console.WriteLine($"{n}年后，我国的人口总数是{x}");

            /*C1 c1 = new C1();
            c1.testSwitch = true;
            Console.WriteLine(c1.TestValue);
            c1.testSwitch = false;
            Console.WriteLine(c1.TestValue);*/
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

    public class C1 
    {
        private int testValue = 0;

        public bool testSwitch = false;

        public int TestValue
        {
            set => testValue = value;
            get 
            {
                if (testSwitch)
                {
                    return testValue;
                }
                else
                    return testValue + 5;
            }
        }
    }
}