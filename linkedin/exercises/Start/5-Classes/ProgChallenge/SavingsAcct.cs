using System;

namespace ProgChallenge {
  class SavingsAcct : Account {
    decimal _interest;
    public SavingsAcct(string name, string lastName, decimal interest, decimal balance)
      : base(name, lastName, balance) {
        Console.WriteLine("INNNN savingsAcct:::", name, lastName, interest, balance);
        _interest = interest;
    }


  }
}