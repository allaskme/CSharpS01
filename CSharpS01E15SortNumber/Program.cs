using System;

namespace CSharpS01E15SortNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                int temp = a; a = b; b = temp;
            }
            if (b > c)
            {
                int temp = b; b = c; c = temp;
            }
            if (a > b)
            {
                int temp = a; a = b; b = temp;
            }
            Console.WriteLine(a + " " + b + " " + c);
        }
    }
}
