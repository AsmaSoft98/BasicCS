class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        int x = 5;
        int y = 8;
        int z = x + y;
        Console.WriteLine("Add Two Numbers：{0}+{1}={2}", x, y, z);

        String str = "Name";
        float f = 3.14f;
        double d = 3.15;
        bool boo = true;
        Console.WriteLine("String:{0},\nfloat:{1},\ndouble:{2},\nbool:{3}", str, f, d, boo);
        //escape characters are not recognized
        Console.WriteLine(@"aaa\nbbb""
                                bbb");
        //output result：aaa\nbbb" new line bbb *define multiple lines

        Console.ReadKey();        //any key to continue
    }
}