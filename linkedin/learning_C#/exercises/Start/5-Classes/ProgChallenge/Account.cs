
namespace ProgChallenge {
  class Account {
    string _name;
    string _lastName;
    public decimal Balance {
      get; set;
    }
    public Account(string name, string lastName, decimal initial = 0.0m) {
      _name = name;
      _lastName = lastName;
      Balance = initial;
    }

    public virtual void Deposit(decimal add) {
      Balance += add;
    }
    public virtual void Withdraw(decimal subt) {
      Balance -= subt;
    }

    public string AccountOwner {
      get => $" {_name} {_lastName}";
    }
  }
}