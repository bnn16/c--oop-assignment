using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

public static class Program
{

	static public void One()
	{
		Console.WriteLine("Enter your name");
		string name = Console.ReadLine();
		Console.WriteLine("Hello, {0} ", name);
	}

	static public void Two()
	{
		Console.WriteLine("Enter a number");
		int num = Int32.Parse(Console.ReadLine());
		if (num % 2 == 0) {
			Console.WriteLine("{0} is even", num);
		}
		else {
			Console.WriteLine("{0} is odd", num);
		}
	}

	static public void Three()
	{
		Console.WriteLine("Enter a base number");
		int baseNum = Int32.Parse(Console.ReadLine());
		Console.WriteLine("Enter a multiplication number");
		int multiNum = Int32.Parse(Console.ReadLine());

		for (int i = 1; i <= multiNum; i++) {
			Console.WriteLine("{0} x {1} = {2}", baseNum, i, baseNum * i);
		}

	}


	public static int findMax(this IList<int> items)
	{
		int maxVal = int.MinValue;
		foreach (int i in items) {
			if (i > maxVal) {
				maxVal = i;
			}
		}
		return maxVal;
	}
	public static int findMin(this IList<int> items)
	{
		int minVal = int.MaxValue;
		foreach (int i in items) {
			if (i < minVal) {
				minVal = i;
			}
		}
		return minVal;
	}

	static public void Four()
	{

		List<int> list = new List<int>();
		float avg = 0;
		float sum = 0;
		float multipli = 1;

		for (int i = 0; i < 4; i++) {
			Console.WriteLine("Enter a base number");
			int test = Int32.Parse(Console.ReadLine());
			list.Add(test);
			avg += test;
			sum += test;
			multipli *= test;
		}



		Console.WriteLine("The average is {0}", avg / list.Count());
		Console.WriteLine("The max is {0}", findMax(list));
		Console.WriteLine("The min is {0}", findMin(list));
		Console.WriteLine("The sum is {0}", sum);
		Console.WriteLine("The multiplication is {0}", multipli);


	}


	static public void Five()
	{
		Console.WriteLine("Enter how many times: ");
		int num = Int32.Parse(Console.ReadLine());
		string[] arr = new string[num];
		int[] arr1 = new int[num];


		for (int i = 0; i < num; i++) {
			Console.WriteLine("Enter name ");
			String input1 = Console.ReadLine();
			Console.WriteLine("Enter age ");
			int age = Int32.Parse(Console.ReadLine());
			arr[i] = input1;
			arr1[i] = age;
		}

		for (int i = 0; i < num; i++) {
			Console.WriteLine("{0} aged {1}", arr[i], arr1[i]);
		}

	}






	static public void Main()
	{
		Five();
	}

}
