
using System;
class NumberChecker1
{
    public static void Main()
    {
        int n=int.Parse(Console.ReadLine());
        int[] d=Digits(n);
        Console.WriteLine(d.Length);
        Console.WriteLine(IsDuck(d));
        Console.WriteLine(IsArmstrong(n,d));
    }
    static int[] Digits(int n)
    {
        char[] c=n.ToString().ToCharArray();
        int[] a=new int[c.Length];
        for(int i=0;i<c.Length;i++)a[i]=c[i]-'0';
        return a;
    }
    static bool IsDuck(int[] d){
        foreach(int x in d)if(x!=0)return true;
        return false;
    }
    static bool IsArmstrong(int n,int[] d)
    {
        int s=0;
        foreach(int x in d)s+=(int)Math.Pow(x,d.Length);
        return s==n;
    }
}
