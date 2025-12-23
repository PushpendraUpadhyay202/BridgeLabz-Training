using System;
class FindFactor{
	static void Main(string[] args){
		int num = int.Parse(Console.ReadLine());
		Console.WriteLine("Factors of "+num+" are:");

		for(int i=1;i<num;i++)
		{
			if(num%i==0)
			{
				Console.WriteLine(i);
			}
		}
	}
}