// MyClass
namespace Practice
{
    public class MyClass
    {
        private string description;

        public MyClass()
        {
            this.description = "This is MyClass!";
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public MyClass ShallowCopy()
        {
            return (MyClass)this.MemberwiseClone();
        }
    }
}

// MyClass Main
namespace Practice
{
    public class Program
    {
        public static void Main()
        {
            MyClass objectA = new MyClass();
            MyClass objectB = objectA.ShallowCopy();

            Console.WriteLine("ObjectA Description =" + objectA.Description);
            Console.WriteLine("ObjectB Description =" + objectB.Description);
        }
    }
}


