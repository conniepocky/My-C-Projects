using System;

namespace jonghyun
{
    class Program
    {
        static void Main(string[] args)
        {
		Console.WriteLine("Jonghyun is the best #BlingBling");
		Console.WriteLine("What message do you want to repeat?");
		
		var message = Console.ReadLine();

		Console.WriteLine("How many times do you want to repeat it?");

		var t = Console.ReadLine();

		for (int i = Int32.Parse(t); i < 30; i++) {
			Console.WriteLine(message);
			System.Threading.Thread.Sleep(1000);
		}
        }
    }
}
