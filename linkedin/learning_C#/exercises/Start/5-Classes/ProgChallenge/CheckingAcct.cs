
namespace ProgChallenge {
  class CheckingAcct : Account {
    private const decimal OVERDRAW_CHARGE = 35.0m;
    public CheckingAcct(string name, string lastName, decimal initial)
      :base(name, lastName, initial) { }

    public override void Withdraw(decimal subt) {
      if (subt > Balance) subt += OVERDRAW_CHARGE;
      base.Withdraw(subt);
    }
  }
}
