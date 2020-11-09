using System;

//Jonathan Aracil 1ºDAM Grupo 1

public class Average{
	
	/*This program calculate the average introducing marks, the program sum numbers and do the average with a total number introduced, the program finish
	when user put "end"*/
		
	public static void Main(){
		
		double sumNumber = 0, number, count = 0, average;
		string mark;
		Console.Write("Insert a mark: ");
		mark = Console.ReadLine();	 
		
		while (mark != "end"){
			number = Convert.ToDouble(mark);
			count++;
			sumNumber += number;
			Console.Write("Insert a mark: ");
			mark = Console.ReadLine();
		}
		
		if (count != 0){
			average = sumNumber/count;
			Console.WriteLine("The average is {0}.", average);
		}
	}
}
