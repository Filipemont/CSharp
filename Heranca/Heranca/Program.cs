using System;


namespace Heranca {
    internal class Program {
        static void Main(string[] args) {
            Account account = new Account(1001, "Alex", 400.0);
           // BusinessAccount businessAccount = new BusinessAccount(1002, "Maria", 500.0, 500.0);

            //Upcasting

           // Account acc = businessAccount;
           // Account acc2 = new BusinessAccount(1003, "Bob", 400.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 400.0, 0.01);

            account.Withdraw(15.0);
            acc3.Withdraw(15.0);

            Console.WriteLine(account.Balance);
            Console.WriteLine(acc3.Balance);




            //Downcasting
            
           // BusinessAccount acc4 = acc2 as BusinessAccount;
            
         //   BusinessAccount acc5 = (BusinessAccount)acc3;
          //  if(acc3 is BusinessAccount) {
          //     BusinessAccount acc5 = (BusinessAccount)acc3;
          //      acc5.Loan(200.0);
          //      Console.WriteLine("Loan!");
         //   }
            //if (acc3 is SavingsAccount) {
              //  SavingsAccount acc5 = acc3 as SavingsAccount;
              //  acc5.UpdateBalance();
               // Console.WriteLine("Update!");
           //*

        }
    }
}

