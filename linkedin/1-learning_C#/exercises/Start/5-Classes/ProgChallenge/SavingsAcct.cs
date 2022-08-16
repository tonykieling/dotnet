
namespace ProgChallenge {
  class SavingsAcct : Account {
    decimal _interest;
    private int _withdrawCount = 0;
    private const int WITHDRAW_LIMIT = 3;
    private const decimal WITHDRAW_ADD_COST = 2.0m;
    public SavingsAcct(string name, string lastName, decimal interest, decimal balance)
      : base(name, lastName, balance) {
        _interest = interest;
    }

    public override void Withdraw(decimal subt) {
      // if (subt > Balance) Console.WriteLine("Withdraw DENIED - insufficient balance");
      
      // else {
      //   _withdrawCount++;
      //   if ( _withdrawCount > WITHDRAW_LIMIT) {
      //     Console.WriteLine("More than 3 withdrawals - extra charge of " + WITHDRAW_ADD_COST);
      //     subt += WITHDRAW_ADD_COST;
      //   }

      //   base.Withdraw(subt);
      // }
      _withdrawCount++;
      if ( _withdrawCount > WITHDRAW_LIMIT) {
        subt += WITHDRAW_ADD_COST;

        if (subt > Balance) {
          _withdrawCount--;
          Console.WriteLine("Withdraw DENIED - insufficient balance");
          subt = 0;
        } else
          Console.WriteLine("More than 3 withdrawals - extra charge of " + WITHDRAW_ADD_COST);
      }
      base.Withdraw(subt);
    }

    public void ApplyInterest() {
      Balance += (Balance * _interest);
    }


  }
}