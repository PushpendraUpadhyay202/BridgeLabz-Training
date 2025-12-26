
using System;
class NumberChecker2
{
    public static void Main()
    {
        int n=int.Parse(Console.ReadLine());
        int[] d=Digits(n);
        Console.WriteLine(Sum(d));
        Console.WriteLine(IsHarshad(n,d));
    }
    static int[] Digits(int n)
    {
        char[] c=n.ToString().ToCharArray();
        int[] a=new int[c.Length];
        for(int i=0;i<c.Length;i++)a[i]=c[i]-'0';
        return a;
    }
    static int Sum(int[] d){
        int s=0;
        foreach(int x in d)s+=x;
        return s;
    }
    static bool IsHarshad(int n,int[] d){
        return n%Sum(d)==0;
    }
}
