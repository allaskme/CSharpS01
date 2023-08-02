namespace CSharpS01E25ScopePractice4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //编写⼀个程序，打印出所有的“⽔仙花数”，所谓“⽔仙花数”是指⼀个三位数，其各位数字⽴⽅等于该数本⾝。例如153 = 1 * 1 * 1 + 5 * 5 * 5 + 3 * 3 * 3，所以153是“⽔仙花数”。
            for(int i = 100; i < 1000;i++)
            {
                int temp = i;
                int sum = 0;
                for (int j = 0; j< 3; j++)
                {
                    int a = temp - temp / 10 * 10;
                    sum += a * a * a;
                    temp /= 10;
                }
                if (sum == i)
                {
                    Console.WriteLine($"{i}是水仙花数");
                }
            }

            // 随机输入一个位数未知的整数，去除这个整数各个位上的0，形成新的数字，并输出
            Console.WriteLine("随机输入一个位数未知的整数，去除这个整数各个位上的0，形成新的数字，并输出");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = 1; // 倍数
            int result = 0;

            while (n > 0)
            {
                int temp = n % 10;
                if (temp != 0)
                {
                    result += temp * m;
                    m *= 10;
                }
                n /= 10;
            }

            Console.WriteLine(result);


            /*
             * 随机输⼊⼀个整数num，输出⼀个新的数，新数恰好与原数每⼀位上的数字相反。（如果原数末尾有多个零，输出的新数⾼位不含0）
             * 样例输⼊ 8736 样例输出 6378
             * 样例输⼊2300 样例输出 32*/
            n = Convert.ToInt32(Console.ReadLine());
            result = 0;
            bool flag = true;

            while (n>0)
            {
                int temp = n % 10;
                if (temp == 0 && flag)
                    n /= 10;
                else
                {
                    flag = false;
                    result *= 10;
                    result += temp;
                    n /= 10;
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}