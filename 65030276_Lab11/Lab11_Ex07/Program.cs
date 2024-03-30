using System;

class Base
{
    public virtual void A()
    {
        Console.WriteLine("Base.A()");
    }
}

class Derived_1 : Base
{
    public sealed override void A()
    {
        Console.WriteLine("Derived_1.A()");
    }
}

class Derived_2 : Derived_1
{
    public new void A()  // ไม่ได้ใช้คำสงวน override
    {
        Console.WriteLine("Derived_2.A()");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Derived_2 d2 = new Derived_2();
        Base b = d2; // ไม่จำเป็นต้องใช้ casting
        Derived_1 d1 = d2; // ไม่จำเป็นต้องใช้ casting

        b.A();
        d1.A();
        d2.A();
    }
}