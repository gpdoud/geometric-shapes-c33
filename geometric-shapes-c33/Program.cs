using System;

namespace geometric_shapes_c33
{
	class Program
	{
		static void Main(string[] args)
		{
			var s1 = new Sqr()
			{
				Side1 = 5
			};
			Console.WriteLine($"Perimeter is {s1.Perimeter()}");
			Console.WriteLine($"Area is {s1.Area()}");

			var r1 = new Rect()
			{
				Side1 = 3, Side2 = 5
			};
			Console.WriteLine($"Perimeter is {r1.Perimeter()}");
			Console.WriteLine($"Area is {r1.Area()}");

			var q1 = new Quad()
			{
				Side1 = 3, Side2 = 4, Side3 = 5, Side4 = 6
			};
			Console.WriteLine($"Perimeter is {q1.Perimeter()}");
		}
	}
}
