namespace CSharpS01E23ScopePractice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double height = Convert.ToDouble(Console.ReadLine());
            double sum = 0;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"");
                sum += height / 2;
            }
            sum += 10;
        }
    }
}