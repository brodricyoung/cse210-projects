using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);

        // looked at changing variables in debugger
        int f3Top = f3.GetTop();
        int f3Bottom = f3.GetBottom();
        f3.SetTop(3);
        f3.SetBottom(4);
        int newf3Top = f3.GetTop();
        int newf3Bottom = f3.GetBottom();

        string frac = f3.GetFractionString();
        double deci = f3.GetDecimalValue();

        Console.WriteLine($"frac: {frac}, deci: {deci}");


    }
}