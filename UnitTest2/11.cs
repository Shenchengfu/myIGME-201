// a.
// first, constructor of the base class (block with lines 15 - 18, the main line is 17), myInt has a value of 42
// second, constructor of the derived class (block with lines 22 - 25, the main line is 24), myInt has a value of (42 + 2) * 4 = 44 * 4 = 176

// b. 
// The value of myObj.myInt is 176 at line #30

namespace Practice
{
    static class Program
    {
        public class MyClass
        {
            public int myInt;

            public MyClass(int nVal)
            {
                this.myInt += nVal;
            }
        }

        public class MyDerivedClass : MyClass
        {
            public MyDerivedClass(int nVal) : base(nVal)
            {
                this.myInt = (this.myInt + 2) * 4;
            }
        }

        static void Main(string[] args)
        {
            MyDerivedClass myObj = new MyDerivedClass(42);
            Console.WriteLine(myObj.myInt);
        }
    }
}
