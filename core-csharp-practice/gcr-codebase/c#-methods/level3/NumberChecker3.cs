
using System;
class NumberChecker3
{
    public static void Main()
    {
        int n=int.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(n));
        Console.WriteLine(IsNeon(n));
        Console.WriteLine(IsBuzz(n));
    }
    static bool IsPrime(int n)
    {
        if(n<=1)return false;
        for(int i=2;i<=n/2;i++) if(n%i==0) return false;
        return true;
    }
    static bool IsNeon(int n)
    {
        int s=0,x=n*n;
        while(x>0){s+=x%10;x/=10;}
        return s==n;
    }
    static bool IsBuzz(int n){
        return n%7==0||n%10==7;
    }
}
