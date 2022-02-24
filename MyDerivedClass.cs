using System;
using System.Collections.Generic;
using System.Text;
class MyDerivedClass : MyClass
{
    public MyDerivedClass(string s) : base(s) {
    }

    public override string GetString()
    {
        return base.GetString() + " (output from the derived class)";
    }

    static void Main() {
        MyClass mc = new MyDerivedClass("Hello!");
        Console.WriteLine(mc.GetString());
    }
}
