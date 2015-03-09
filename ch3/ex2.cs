using System;

class UseDecimal {
  static void Main() {
    decimal price;
    decimal discount;
    decimal discounted_price;

    price = 19.95m;
    discount = 0.15m;

    discounted_price = price - ( price * discount );

    Console.WriteLine("Discounted price: $" + discounted_price);
  }
}
