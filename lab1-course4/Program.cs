using System;

public class Program
	{
		public static void Main()
		{
			int thousands = 1;
			int number = Convert.ToInt32(Console.ReadLine());
			if (number > 1000)
			{
				thousands = (number / 1000) * 10;
			}
			int hundreds = (number % 1000) / 100;
			int sum = thousands + hundreds;
			Console.WriteLine(sum);

		}
	}

