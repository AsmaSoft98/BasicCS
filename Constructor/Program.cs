//constructor
/*
 1.called when object is created
2.having same name as classname
3.does not have return type ie void or int or string
4.comiler bydefault provides definition 
if no user defined constructor available
5.in case of derived class constructor is the 
first line of code is super()
6.constructor chaining is followed while creating 
and deleteing child objects in inheritance
types
1.default(compiler provided)
2.default(user defined)
3.parameterised(user defined)
4.static constructor
5.copy constructor (compiler provided )
6.copy constructor (user defined)
7.private constructor
8.default parameterised/argument constructor
9.
 */


namespace ConsoleApp11_constructor
{
    class A
    {
        static int inst_code;
        static string inst_name;
        private A()
        {
            Console.WriteLine("calling private constructor");
        }
        static A()
        {
            inst_code = 365;
            inst_name = "Naim";
        }
        public static void show()
        {
            Console.WriteLine("inst_code:{0}  inst_name:{1}", inst_code, inst_name);
        }
    }


    class Base
    {
        protected string name;
        public Base()
        {
            Console.WriteLine("Base() called");
        }
    }

    class Derived : Base
    {
        protected string city;

        public Derived()
        {
            Console.WriteLine("Derived() called");
        }
    }
    class Derivedtocall : Derived
    {
        string state;
        public Derivedtocall(string name, string city, string state)
        {
            this.name = name;
            this.city = city;
            this.state = state;
            Console.WriteLine("Derivedtocall() called");
        }

        public void show()
        {
            Console.WriteLine("name:{0} city:{1} state:{2}", this.name, this.city, this.state);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance");
            Derivedtocall derived = new Derivedtocall("Sami", "Rash", "London");
            derived.show();

            Console.ReadKey();
        }
    }
}