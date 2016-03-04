using System;

public class Strings {
	static void Main(string[] args){
		string myString = "Go to your C:\\drive";
		string myString = "My \"so called\" life";
		string myString = "What if I need \n a new line?";

		string myString = string.Format("{0}!", "Neyo");
		string myString = string.Format("Make: {0} (Model: {1})", "BMW", "706li");

		string myString = string.Format("{0:C}", 123.45);
		string myString = string.Format("{0:N}", 123456789);
		string myString = string.Format("{0:P}", .123);
		string myString = string.Format("Phone number: {0: (###) ###-####}", 1234567890);

		string myString = "";

		for (int i = 0; i < 100; i++)
		{
			myString = myString + "--" + i.ToString();
			myString += "--" + i.ToString();
		}

		StringBuilder myString = new StringBuilder();

		for (int i = 0; i < 100; i++)
		{
			myString.Appened("--");
			myString.Appened(i);
		}

		Console.WriteLine(myString.ToString());

		string myString = "That summer we took acroos the board";
		
		myString = myString.Substring(5,14);
		myString = myString.toUpper();
		myString = myString.Replace("", "--");
		myString = String.Format("Length before: {0} -- After: {1}",
								myString.Length, myString.Trim().Length);
		

		Console.WriteLine(myString);

		Console.ReadLine();
	}
}