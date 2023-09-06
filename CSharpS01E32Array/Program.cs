using System;
using System.Data;

namespace CSharpS01E32Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 数组
            int[] intArray = new int[9];
            char[] charArray = new char[20];
            float[] floatArray = new float[5];
            string[] stringArray = new string[8];

            foreach (int i in intArray)
            {
                Console.WriteLine(i);
            }

            foreach (char c in charArray)
            {
                Console.WriteLine(c);
            }

            foreach (float f in floatArray)
            {
                Console.WriteLine(f);
            }

            foreach (string s in stringArray)
            {
                Console.WriteLine(s);
            }
        }
    }
}
