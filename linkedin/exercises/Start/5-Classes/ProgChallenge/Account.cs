using System;

namespace ProgChallenge {
  class Account {
    string _name;
    string _lastName;
    decimal _balance;
    public Account(string name, string lastName, decimal balance) {
      Console.WriteLine("NEW ACCOUNT:::", name, lastName, balance);
      _name = name;
      _lastName = lastName;
      _balance = balance;
    }

    // public virtual float Deposit {
    //   get; set;
    // }
    // public virtual float Withdrawal {
    //   get; set;
    // }

    public decimal Balance() {
      Console.WriteLine("balance:::", _balance);
      return _balance;
    }

  //   public string AccountOwner() {
  //     return $" {_name} {_lastName}";
  //   }
  }
}