namespace CSharpS01E27CharRead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 字符读取基础
            char a = (char)Console.Read();
            /*这里会有个小问题，如果输入一个字符，然后点回车后，直接就结束了，
             * 因为回车后，在执行下面一行时，回车也当做一个字符进行处理，看上去
             * 好像跳过了char b = (char)Console.Read();
             */
            char b = (char)Console.Read();

            Console.WriteLine("---------");//这里验证上面的注释

            Console.WriteLine(a);
            Console.WriteLine(b);

            /*
             * 编程题1
             * 数字和字符混合在一起了，作为一个优秀的挖掘人员，把输入的数字挖出来，并计算这些数字的和，并输出。输入以@作为结束
             * 样例：23a34b34@
             * 输出：19
             */
            
            Console.WriteLine("---------编程题1----------");
            char c;
            int sum = 0;
            do
            {
                c = (char)Console.Read();
                if (c >= '0' && c <= '9')
                {
                    int number = c - '0';//因为char类型存储的是字面的ASCII码，对应到整数需要减去‘0’（‘0’对应的int是55）
                    sum += number;
                }
            } while (c != '@');

            Console.WriteLine($"和是{sum}");

            /*
             * 编程题2
             * 假设有一个字符隧道，隧道以字符‘#’，结束，挖矿过程中，会遇到钻石‘*’和美金‘1~9’，让矿工小六挖到隧道的尽头，假设每个
             * 钻石价值500美金，统计小六挖到的矿价值多少美金？
             * 样例：ka4d*s6kkl8s*d9fyo=#
             * 输出：1027
             */
            Console.WriteLine("---------编程题2----------");
            char d;
            int dollar = 0;
            do
            {
                d = (char)Console.Read();
                if (d >= '0' && d <= '9')
                {
                    int number = d - '0';
                    dollar += number;
                }
                else if (d == '*')
                    dollar += 500;
            } while (d != '#');
            Console.WriteLine($"小六挖到的矿价值{dollar}美金");
        }
    }
}