// b/c int only holds up to 2,147,483,647 we need to use long here
using System;

class Inches {
  static void Main() {
    long inches;
    long miles;

    miles = 93000000;
    inches = miles * 5280 * 12;

    Console.WriteLine(String.Format("Distance to the sun: {0} inches", inches));

  }	
}
