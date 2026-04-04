using System;

class Vehicle{}

class ElectricVehicle : Vehicle{}
public class Operator
{
    public static void Main(String [] args)
    {
        //1.Assignment Operator
        int a = 10;
        int b = 5;

        Console.WriteLine("a+b: "+ (a+b)); //15
        Console.WriteLine("a-b: "+ (a-b)); //5
        Console.WriteLine("a*b: "+ (a*b)); //50
        Console.WriteLine("a/b: "+ (a/b)); //2
        Console.WriteLine("a%b: "+ (a%b)); //0

        //2.Relational Operator

        Console.WriteLine("a==b: "+ (a==b)); //false
        Console.WriteLine("a!=b: "+ (a!=b)); //true
        Console.WriteLine("a>b: "+ (a>b)); //true
        Console.WriteLine("a<b: "+ (a<b)); //fasle
        Console.WriteLine("a>=b: "+ (a>=b)); //true
        Console.WriteLine("a<=b: "+ (a<=b)); //false

        //3.Logical Operator

        bool x = true;
        bool y = false;

        Console.WriteLine("x&&y: "+ (x&&y)); //false
        Console.WriteLine("x||y: "+ (x||y)); //true
        Console.WriteLine("!x: "+ (!x)); //false

        //4. Assignment Operator

        int m = 20;
        int n = 30;

        m+=n; // m = m+n;
        Console.WriteLine("m+=n: " + (m)); //50
        m-=n; // m = m-n;
        Console.WriteLine("m-=n: " + (m)); //20
        m*=n; // m = m*n;
        Console.WriteLine("m*=n: " + (m)); //600
        m/=n; // m = m/n;
        Console.WriteLine("m/=n: " + (m)); //20
        m%=n; // m = m%n;
        Console.WriteLine("m%=n: " + (m)); //20

        //5.Unary Operators
        int p = 5;

        Console.WriteLine("p++: "+ (p++)); //print 5 but p = 6
        Console.WriteLine("p--: "+ (p--)); // print 6 but p = 5
        Console.WriteLine("++p: "+ (++p)); //print 6 and also p =6
        Console.WriteLine("--p: "+ (--p)); //print 5 and also p=5

        //6.Bitwise Operator
        int c = 3; //011
        int d = 4; //100

        Console.WriteLine("c&d : "+ (c & d)); // 000
        Console.WriteLine("c | d : "+ (c | d)); // 111
        Console.WriteLine("c ^ d : "+ (c ^ d)); //111
        Console.WriteLine("~c :"+ (~c)); //100
        Console.WriteLine("c << 1 : "+ (c <<1));
        Console.WriteLine("c >> 1 : "+ (c >>1));
        
        //7.Ternary Operator
        Console.WriteLine("a= :"+ (a)); //10
        Console.WriteLine("b= :"+ (b)); //5

        int max = (a>=b) ? a : b;

        Console.WriteLine("max is : "+ (max));

        //8. Is Operator

        Vehicle vehicle = new ElectricVehicle();

        Console.WriteLine((vehicle is Vehicle)); //true
        Console.WriteLine((vehicle is ElectricVehicle)); //true
        // Console.WriteLine((vehicle is Vehicle)); //true
        


    }
}