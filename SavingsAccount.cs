using System;

class SavingsAccount : BankAccount
{
  public override void CalculateInterest()
  {
  Balance = Balance + (Balance * 0.05);
  Console.WriteLine("Balance after interest = ${0}", Balance);
  }
      
  public override void Withdraw(double amount)
  {
    if (Balance < 2000)
    {
      Console.WriteLine("error. insufficient balance");
    }
    else
    {
      base.Withdraw(amount);
    }
  }
}