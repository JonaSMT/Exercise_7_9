using System;

//Jonathan Aracil 1ºDAM Group 1

class digits
{
	//The program consist in introduce numbers and show how much digits have each number
	static void Main()
	{
		int oneDigit = 0, twoDigits = 0, threeDigits = 0, fourOrMoreDigits = 0;
		Console.Write("Insert a number: ");
		string mark = Console.ReadLine();
		
		while (mark != "end"){
			int input = Convert.ToInt32(mark);
			if (input != 0)
			{	
				if (input / 10 == 0)
					oneDigit++;
				else 
				
				if (input / 100 == 0)
					twoDigits++;
				else
				
				if (input / 1000 == 0)
					threeDigits++;  
				else
					fourOrMoreDigits++;  
			}
		mark = Console.ReadLine();
		}
		Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", oneDigit, twoDigits, threeDigits, fourOrMoreDigits); 
	}
}

