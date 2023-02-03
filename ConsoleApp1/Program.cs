class Program
{
    static void Main(string[] args)
    {
        //Example1
        //    Console.WriteLine("Hello World");
        //    int x = 5;
        //    int y = 8;
        //    int z = x + y;
        //    Console.WriteLine("Add Two Numbers：{0}+{1}={2}", x, y, z);

        //    String str = "Name";
        //    float f = 3.14f;
        //    double d = 3.15;
        //    bool boo = true;
        //    Console.WriteLine("String:{0},\nfloat:{1},\ndouble:{2},\nbool:{3}", str, f, d, boo);
        //    //escape characters are not recognized
        //    Console.WriteLine(@"aaa\nbbb""
        //                            bbb");
        //    //output result：aaa\nbbb" new line bbb *define multiple lines

        //    Console.ReadKey();        //any key to continue

        //Example2
        //String str = Console.ReadLine();
        //Console.WriteLine(str);
        ////int i = Convert.ToInt32(str);
        //double i = Convert.ToDouble(str);
        //i++;
        //Console.WriteLine(i);

        //Console.ReadKey();

        //Example3
        //Rabbit breeding problem, starting with a pair of rabbits, and starting from the third month,
        //a pair of rabbits will be bred every month,
        //مشكلة تربية الأرانب ابتداءً من زوج من الأرانب
        //وابتداءً من الشهر الثالث ،
        // ستتم الزيادة بزوج من الأرانب كل شهر ،
        //The newly bred rabbits also breed a pair of rabbits every month after three months

        //تتكاثر الأرانب التي تم تربيتها حديثًا أيضًا زوجًا من الأرانب كل شهر بعد ثلاثة أشهر。

        //عدد الأرانب
        //int dozen = 0;
        //int month0 = 0;
        //int month1 = 0;
        //int month2 = 0;
        //for (int month = 0; month <= 20; month++)
        //{
        //    if (month == 0)
        //    {
        //        month0 += 2;
        //        continue;
        //    }

        //    dozen = dozen + month2;
        //    month2 = month1;
        //    month1 = month0;
        //    month0 = dozen;
        //    Console.WriteLine("month：{0}:big rabbit：{1},bunny：{2},{3},{4}", month, dozen, month2, month1, month0);
        //}

        //int sum = dozen + month0 + month1 + month2;
        //Console.WriteLine("Total number of rabbits after 20 months：{0}", sum);
        //Console.ReadKey();
    }
}