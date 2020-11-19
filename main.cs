using System;

class MainClass {
  public static void Main (string[] args) {

  Console.WriteLine("For savings account");
  SavingsAccount case1 = new SavingsAccount();
  case1.Deposit(2000);
  case1.Withdraw(5000);
  case1.CalculateInterest();
  case1.Withdraw(500);

  Console.WriteLine(" ");

  Console.WriteLine("For checkings account");
  CheckingAccount case2 = new CheckingAccount();
  case2.Deposit(2000);
  case2.Withdraw(5000);
  case2.CalculateInterest();
  case2.Withdraw(500);

            /*Test case 1
             * Create a savingsaccount object
             * Deposit $2000
             * Withdraw $5000
             * Calculate interest
             * Withdraw $500
            */

            /*Test case 2
            * Create a checkingaccount object
            * Deposit $2000
            * Withdraw $5000
            * Calculate interest
            * Withdraw $500
           */
  }
}