namespace CSharpS01E26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("回文数练习");

            // 回文数是指正序和倒序读都一样的整数。输入一个数，范围在0-10000000，判断是否是回文数，如果是输出yes，如果不是输出no

            int check = Convert.ToInt32(Console.ReadLine());
            int zhengxu = check;
            int result = 0;
            bool flag = true;

            while(check > 0)
            {
                int temp = check % 10;
                if (temp == 0 && flag)
                {
                    check /= 10;
                }
                else
                {
                    flag = false;
                    result *= 10;
                    result += temp;
                    check /= 10;
                }
            }

            if (result == zhengxu)
            {
                Console.WriteLine($"输入的数字是{zhengxu},回文后的数字是{result},{zhengxu}是回文数字。");
            }
            else
                Console.WriteLine($"输入的数字是{zhengxu},回文后的数字是{result},{zhengxu}不是回文数字。");


        }
    }
}