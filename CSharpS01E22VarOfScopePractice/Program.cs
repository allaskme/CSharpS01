namespace CSharpS01E22VarOfScopePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 让用户输入整数，如果用户输入的不是0，就继续输入，如果是0，就结束输入，并输出所有整数的和，这里扩展了一下，把输入的数字存成一串，显示出来
            int sum = 0;

            Console.Write("请输入一个整数：");

            string? inputS = Console.ReadLine();

            string cacheString = "";

            while (!string.IsNullOrEmpty(inputS) && !string.IsNullOrWhiteSpace(inputS))
            {
                int input = Convert.ToInt32(inputS);

                if (input == 0)
                {
                    Console.WriteLine("输入为0，结束输入！");
                    break;
                }
                else
                {
                    cacheString += inputS + " ";
                    sum += input;
                    Console.Write("请再输入一个整数:");
                    while (true)
                    {
                        inputS = Console.ReadLine();
                        if (inputS != null)
                            break;
                    }

                    input = Convert.ToInt32(inputS);
                }
            }

            Console.WriteLine(cacheString);
            Console.WriteLine($"上面输入的整数的和是:{sum}");
        }
    }
}