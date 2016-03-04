using System;

public class Date_Time{
	static void Main(string[] args)
	{
		DateTime myValue = DateTime.Now;
		Console.WriteLine(myValue.ToString());
		Console.WriteLine(myValue.ToShortDateString());
		Console.WriteLine(myValue.ToShortTimeString());
		Console.WriteLine(myValue.ToLongDateString());
		Console.WriteLine(myValue.ToLongTimeString());

		Console.WriteLine(myValue.AddDays(3).ToLongDateString());
		Console.WriteLine(myValue.AddHours(3).ToShortTimeString());

		Console.WriteLine(myValue.AddDays(-3).ToLongDateString());

		Console.WriteLine(myValue.Month.ToString());

		DateTime myBirthday = new DateTime(1969, 12, 7);
		Console.WriteLine(myBirthday.ToShortDateString());

		DateTime myBirthday = DateTime.Parse("12/7/1969");
		TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
		Console.WriteLine(myAge.TotalDays);

		Console.ReadLine();
	}
}