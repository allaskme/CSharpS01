namespace CSharpS01E36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 编程题：输入N个正整数，用空格分开，输出这N个数中第二大的数 
             */
            SecondNumber();
        }

        public static void SecondNumber()
        {
            Console.WriteLine("---------编程题：输入的数字中第二大的数-----------");
            Console.Write("请输入10个不相等的正整数，用空格分开：");
            string inputS = Console.ReadLine();
            string[] splitS = inputS.Split(" ");
            int[] ints = new int[splitS.Length];

            for (int i = 0; i < splitS.Length; i++)
            {
                ints[i] = Convert.ToInt32(splitS[i]);
            }

            // 原计划用冒泡排序，又想出一种思路，先试试新思路
            /*for (int i = 0; i < ints.Length - 1; i++)
            {
                bool isSwitch = false;
                for (int j = 0; j < ints.Length - i - 1; j++)
                {
                    if (ints[j] > ints[j + 1])
                    {
                        int temp = ints[j + 1];
                        ints[j + 1] = ints[j];
                        ints[j] = temp;
                        isSwitch = true;
                    }
                }
                if (!isSwitch)
                    break;
            }

            foreach (int i in ints)
            {
                Console.Write($"{i} ");
            }*/

            int max = 0;
            int second = 0;

            // 先把数组的第1和第2个数比较后分别放在最大值和第二大值的变量，如果相等，只赋最大值
            if (ints[0] > ints[1])
            {
                max = ints[0];
                second = ints[1];
            }
            else if (ints[0] < ints[1])
            {
                max = ints[1];
                second = ints[0];
            }
            else
            {
                max = ints[1];
            }
            
            // 从第三个数开始循环比较最大值和第二大值
            for (int i = 2; i < ints.Length; i++)
            {
                int temp = ints[i];
                if (max < temp)
                {
                    second = max;
                    max = temp;
                }
                else if (max > temp && second < temp)
                {
                    second = temp;
                }
            }

            Console.WriteLine($"最大值是{max},第二大值是{second}");
        }
    }
}
