using System;

public static class Calculator
{
    public static int AddValues(int a, int b)
    {
        Console.WriteLine("Calculated by method: public static int AddValues(int a, int b)");
        return a + b;
    }
    
    public static float AddValues(float c, float d)
    {
        Console.WriteLine("Calculated by method: public static float AddValues(float c, float d)");
        return c + d;
    }
    
    public static long AddValues(long e, long f)
    {
        Console.WriteLine("Calculated by method: public static long AddValues(long e, long f)");
        return e + f;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Calculator.AddValues(2, 3));
        Console.WriteLine(Calculator.AddValues(2.0f, 3.0f));
        Console.WriteLine(Calculator.AddValues(2L, 3L));
    }
}