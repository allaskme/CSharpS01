namespace CSharpS01E23ScopePractice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 一个小球从height高度下落，经过10次落地和反弹，每次反弹是前次反弹高度的一半，求小球10次落地过程中的总行程及10次落地每次的高度
            double height = Convert.ToDouble(Console.ReadLine());
            double sum = height;

            Console.WriteLine($"初始的高度是：{height}");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"第{i + 1}次落地的行程是：{sum}");
                height /= 2;
                Console.WriteLine($"第{i + 1}次反弹的高度是：{height}");
                if (i != 9)
                {
                    sum += height * 2;
                }
            }
            Console.WriteLine($"小球总的行程是{sum}");
            //sum += 10;

            // 类的实例变量、静态变量以及常量
            Test test = new Test();
            test.Mem1 = 1;
            Test.Count();
            Console.WriteLine(test.Mem1 + " 计数："+ Test.Mem2);
            Test test1 = new Test();
            test1.Mem1 = 2;
            Test.Count();
            Console.WriteLine(test.Mem1 + "   " + test1.Mem1 + " 计数：" + Test.Mem2);

        }

        class Test
        {
            public int Mem1;
            static public int Mem2 = 0;
            
            static public void Count()
            {
                Mem2++;
            }
        }
    }
}