using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

public static class Program
{

	public class Snack
	{
		public string name { get; set; }
		public double price { get; set; }
		public uint amount { get; set; }
		public Snack(string cName, double cPrice, uint cAmount)
		{
			this.name = cName;
			this.price = cPrice;
			this.amount = cAmount;
		}



		public string GetName()
		{
			return this.name;
		}

		public string GetPrice()
		{
			return this.price.ToString();
		}

		public bool DecreaseStock(uint amount)
		{
			if (amount > this.amount) {

				return false;
			}
			else {
				this.amount -= amount;
				return true;
			}


		}

		public string GetAmountInStock()
		{
			return this.amount.ToString();
		}
	}

	public class SnackBar
	{
		public Snack snack1 { get; set; }
		public Snack snack2 { get; set; }
		public Snack snack3 { get; set; }
		public double totalPrice = 0;


		public SnackBar()
		{
			this.snack1 = new Snack("Licorish", 0.20, 10);
			this.snack2 = new Snack("Beef Jerkey", 4.20, 100);
			this.snack3 = new Snack("Chips", 1.20, 2);
		}

		public double ProcessOrder(uint snack1, uint snack2, uint snack3)
		{

			if (this.snack1.DecreaseStock(snack1)) {
				totalPrice += this.snack1.price * snack1;
			}
			else {

				return -1;
			}
			if (this.snack2.DecreaseStock(snack2)) {
				totalPrice += this.snack2.price * snack2;
			}
			else {

				return -1;
			}
			if (this.snack3.DecreaseStock(snack3)) {
				totalPrice += this.snack3.price * snack3;
			}
			else {

				return -1;
			}
			return totalPrice;
		}

		public double GetRevenue()
		{
			return totalPrice;
		}
	}

	//public class SnackBar : Snack
	//{

	//}

	static public void Main()
	{
		SnackBar order = new SnackBar();

		Console.Write(order.ProcessOrder(10, 101, 2));
		Console.Write("{0} , {1} , {2}", order.snack1.amount, order.snack2.amount, order.snack3.amount);
		//Console.WriteLine(order.GetRevenue());

	}

}
