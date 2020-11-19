 using System;
 
 abstract class BankAccount
    {
        public string AcctNbr { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public DateTime DateCreated { get; set; }

        public BankAccount() :this(1000)
        {
        }

        public BankAccount(double balance)
        {
          Balance = balance;
        }

        public void Deposit(double amount)
        {
          Balance = amount + Balance;
          Console.WriteLine("Current balance = {0}", Balance);
        }

        public virtual void Withdraw(double amount)
        {
          if (Balance > amount)
          {
            Balance = (Balance - amount);
            Console.WriteLine("New balance = ${0}", Balance);
          }
          else 
          {
            Console.WriteLine("Error. Insufficient funds");
          }
        }

       public abstract void CalculateInterest();

    }