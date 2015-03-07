using System;

class Example3 {
	static void Main() {
		int ivar;
		double dvar;

		ivar = 100;

		dvar = 100.0;

		Console.WriteLine("orig value of ivar: " + ivar);
		Console.WriteLine("orig value of dvar: " + dvar);

		Console.WriteLine();

		ivar = ivar / 3;
		dvar = dvar / 3.0;

		Console.WriteLine("ivar after div: " + ivar);
		Console.WriteLine("dvar after div: " + dvar);
	}
}
