using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

public static class Program
{

	public class Lottery
	{
		public int maxValue { get; set; }
		public int numWanted { get; set; }
		public List<int> listNumbers = new List<int>();

		public Lottery(int cMaxVal, int cNumWanted)
		{
			this.maxValue = cMaxVal;
			this.numWanted = cNumWanted;
		}

		public int DrawNextNubmer()
		{
			var rand = new Random();
			int number;
			number = rand.Next(1, this.maxValue);
			for (int i = 0; i < 1; i++) {
				do {
					number = rand.Next(1, this.maxValue);
				} while (listNumbers.Contains(number));
				listNumbers.Add(number);
			}

			return number;
		}

		public bool IsLotteryFinished()
		{
			if (listNumbers.Count == this.numWanted) {
				return true;
			}
			else {
				return false;
			}
		}


		public int[] DrawAllNums()
		{
			var rand = new Random();
			int max = this.numWanted;
			int[] numbersArr = new int[max];
			int numNeededToMax = max - listNumbers.Count;
			for (int i = 0; i < numNeededToMax; i++) {
				int nextNum = DrawNextNubmer();
				numbersArr = listNumbers.ToArray();
			}
			return numbersArr;
		}

	}



	static public void Main()
	{

		Console.Write("Hey there, welcome to the Lotto \n");

		Console.Write("Please enter the max number that a ball can have : ");
		int maxBallVal = Convert.ToInt32(Console.ReadLine());
		Console.Write("\nPlease enter the the number of balls you want to draw : ");
		int ballDraw = Convert.ToInt32(Console.ReadLine());
		Console.Write("\n Want to draw all numbers? All/One ");
		string draw = Console.ReadLine();
		int count = 0;
		bool input = true;



		Lottery lotto = new Lottery(maxBallVal, ballDraw);
		int[] arr = new int[ballDraw];
		while (true) {
			if (draw == "All") {
				arr = lotto.DrawAllNums();
				Console.Write(arr);

				for (int i = 0; i < ballDraw; i++) {
					Console.Write(arr[i] + " ");
				}
				Console.Write("\nGG!");
				break;
			}

			if (draw == "One") {
				for (int i = 0; i < 1; i++) {
					int numDrawn = lotto.DrawNextNubmer();
					arr[count] = numDrawn;
					count++;
				}

				if (lotto.IsLotteryFinished() == true) {
					for (int i = 0; i < ballDraw; i++) {
						Console.Write(arr[i] + " ");
					}
					Console.Write("\nGG!");
					break;
				}
			}
			Console.Write("\n Want to draw all numbers? All/One ");
			draw = Console.ReadLine();

		}
	}

}