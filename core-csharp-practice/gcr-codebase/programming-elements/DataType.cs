using System;

public class DataTye
{
    public static void Main(String[] args)
    {
        //Primitive Data Types
        int a = 5; //Size: 32-bit , Range: -2,147,483,648 to 2,147,483,647
        Console.WriteLine(a);

        byte b = 218;  //Size: 8-bit , Range: 0 to 255
        Console.WriteLine(b);

        short s  = 225; //Size: 16-bit , Range: -32768 to 32767
        Console.WriteLine(s);

        long l = 22141; //Size: 64-bit , Range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        Console.WriteLine(l);

        float f = 5.8f; //Size: 32-bit IEEE 754 floating point , Range: ±3.40282347E+38F (6-7 significant decimal digits)
        Console.WriteLine(f);

        double d = 45.564; //Size: 64-bit IEEE 754 floating point , Range: ±1.7976931348623157E+308 (15-16 significant decimal digits)
        Console.WriteLine(d);

        char c = 'q';  //Size: 16-bit Unicode character , Range: 0 to 65,535 (for Unicode characters)
        Console.WriteLine(c);

        bool bo = true; //Size: 1-bit , Range: true or false
        bool wo = false;
        Console.WriteLine(bo);
        Console.WriteLine(wo);
    }
}