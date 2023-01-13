using System;

namespace CSharpS01E18While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //while (i < 11)
            //{
            //    i++;
            //    Console.WriteLine(i);
            //}

            //i = 0;
            //while (i < 11)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            int i = 1;
            while(i <= 100)
            {
                Console.WriteLine(i);
                i++;
            }

            i = 0;
            while (i < 100)
            {
                i++;
                Console.WriteLine(i);
            }

            i = 1;
            int sum = 1;
            while (i < 100)
            {
                i++;
                sum += i;
            }
            Console.WriteLine(sum);

            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                if(n<=m)
                {
                    if(n%2==0)
                    {
                        Console.WriteLine(n);
                    }


                }
            }
        }
    }
}
