
using System;
class BMI
{
    public static void Main()
    {
        double[,] arr=new double[10,3];
        for(int i=0;i<10;i++)
        {
            arr[i,0]=double.Parse(Console.ReadLine());
            arr[i,1]=double.Parse(Console.ReadLine());
        }
        Calculate(arr);
        string[] s=Status(arr);
        for(int i=0;i<10;i++)Console.WriteLine(arr[i,0]+" "+arr[i,1]+" "+arr[i,2]+" "+s[i]);
    }
    static void Calculate(double[,] a)
    {
        for(int i=0;i<10;i++)
        {
            double h=a[i,1]/100;
            a[i,2]=a[i,0]/(h*h);
        }
    }
    static string[] Status(double[,] a)
    {
        string[] s=new string[10];
        for(int i=0;i<10;i++)
        {
            if(a[i,2]<=18.4)s[i]="Underweight";
            else if(a[i,2]<=24.9)s[i]="Normal";
            else if(a[i,2]<=39.9)s[i]="Overweight";
            else s[i]="Obese";
        }
        return s;
    }
}
