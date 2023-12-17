namespace CSharpS01E35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * P093：回文串-最长连续天数
             */

            /*
             * 第1题：回文串是⼀个正读和反读都⼀样的字符串，⽐如“level”或者“noon”等等就是回⽂串。请写⼀个
            程序判断读⼊的字符串是否是“回⽂”。
             */
            IsHuiwen();

            /*
             * 第2题：最长连续天数，比如给定一组天气数据，用空格分开，判断最长连续升温的天数
             */
            UpdateWeatherDay();
        }

        public static void IsHuiwen()
        {
            Console.WriteLine("---------编程题：回文串-----------");
            Console.Write("请输入一个字符串：");
            string readString = Console.ReadLine();
            int length = readString.Length;
            bool isHuiwen = true;

            for (int i = 0; i < readString.Length / 2; i++)
            {
                char cFront = readString[i];
                char cEnd = readString[length - 1 - i];
                if (cFront == cEnd)
                    ;
                else
                {
                    isHuiwen = false;
                    break;
                }
            }

            if (isHuiwen)
            {
                Console.WriteLine($"{readString}是回文串");
            }
            else
            {
                Console.WriteLine($"{readString}不是回文串");
            }
        }

        public static void UpdateWeatherDay()
        {
            Console.WriteLine("----------第2题：连续升温的天数----------");
            Console.Write("请输入一组天气温度数据，用空格分开：");
            string temperature = Console.ReadLine();
            string[] sTemp = temperature.Split(' ');
            int[] iTemperature = new int[sTemp.Length];
            int maxDay = 0;
            int tempDay = 0;

            for (int i = 0;i < sTemp.Length;i++)
            {
                iTemperature[i] = Convert.ToInt32(sTemp[i]);
            }

            for (int i = 0; i< iTemperature.Length - 1 ;i++)
            {
                if (iTemperature[i + 1] > iTemperature[i])
                {
                    tempDay += 1;
                }
                else
                {
                    if(maxDay < tempDay)
                    {
                        maxDay = tempDay;
                    }
                    tempDay = 0;
                }
            }

            Console.WriteLine($"最大连续升温天数是{maxDay}");
        }
    }
}
