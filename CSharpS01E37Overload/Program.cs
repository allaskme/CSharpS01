namespace CSharpS01E37Overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------编程：函数重载-----------");
            Console.WriteLine(MaxValue(new int[] { 1, 3, 5, 6, 12, 14}));
            Console.WriteLine(MaxValue(new double[] { 2.2, 5.3, 4.7, 90.231 }));
        }

        static int MaxValue(int[] ints)
        {
            int intMax = ints[0];
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > intMax)
                    intMax = ints[i];
            }
            return intMax;
        }

        static double MaxValue(double[] doubles)
        {
            double doubleMax = doubles[0];

            for(int i = 0; i < doubles.Length;i++)
            {
                if (doubles[i] > doubleMax)
                    doubleMax = doubles[i];
            }

            return doubleMax;
        }
    }
}
