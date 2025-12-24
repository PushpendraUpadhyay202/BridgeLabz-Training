using System;
public class CanVoteUsingArray{
	static void Main(string[] args)
	{
		Console.WriteLine("Enter the ages of 10 students:");
		int[] studentage = new int[10];//size is given
		
		for(int i=0;i<studentage.Length;i++)
		{
			studentage[i] = int.Parse(Console.ReadLine());
		}

		for(int i=0;i<studentage.Length;i++)
		{
			if(studentage[i] >= 18)
			{
				Console.WriteLine("The student with the age "+studentage[i]+ " can vote");
			}
            else if(studentage[i] < 18 && studentage[i] > 0)
			{
                Console.WriteLine("The student with the age "+studentage[i]+" cannot vote");
			}
            else{
                Console.WriteLine("invalid age");
			}
		}			

	}
}