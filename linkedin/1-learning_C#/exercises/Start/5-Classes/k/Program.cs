using System;

namespace K {
  class Program {
    static void Main(string[] args) {
      A a = new A("Tony");
      Console.WriteLine($"a = {a.GetA()}");

      B b = new B("Tony", "KKK");
      Console.WriteLine($"b = {b.GetB()}");
      Console.WriteLine(b.GetB());
    }
  }
}