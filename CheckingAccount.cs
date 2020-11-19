using System;

class CheckingAccount : BankAccount
    {
      public override void CalculateInterest()
      {
        Balance = Balance + (Balance * 0.005);
        Console.WriteLine("Balance after interest = ${0}", Balance);
      }
      
      public override void Withdraw(double amount)
      {
        base.Withdraw(amount);
      }

    }