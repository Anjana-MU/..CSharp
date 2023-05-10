using System;


namespace Learning_2023
{
    //We have a interface IBankAccount and two classes SavingAccount and CurrentAccount which inherit this interface
    //IBankAccount interface inherits from IAccCreationDetails interface so any class that implements IBankAccount should also implement method frm IAccCreationDetails
    //interface keyword followed by the interface name starting with I is used to define an interface
    //By default interfaces are public, you cannot define any other access modifier for the interface

    interface IAccCreationDetails
    {
        DateTime AccCreated { get; }

        static IAccCreationDetails()
        {
            Console.WriteLine("Interface can contain static constructors");
        }
    }

    //interface can inherit from another interface
    //The derived interface inherits the members from its base interfaces.
    //A class that implements a derived interface must implement all members in the derived interface,
    //including all members of the derived interface's base interfaces.
    interface IBankAccount : IAccCreationDetails
    {
        //interface can have only static fields
        public static int nNextAccountNumber = 1000;

        //Access modifier can be used only for interface members with default implementation
        internal static int nextAccountNo()
        {
            return ++nNextAccountNumber;
        }

        bool DepositAmount(decimal amount);
        bool WithdrawAmount(decimal amount);
        decimal CheckBalance();
    }



    public class SavingAccount : IBankAccount
    {
        private decimal Balance = 0;
        private readonly decimal PerDayWithdrawLimit = 10000;
        private decimal TodayWithdrawal = 0;
        private DateTime accCreated = DateTime.Now;

        //even if the interface is having declration of only get, you can still add set is dervied class
        public DateTime AccCreated
        {
            get { return this.accCreated; }
            set { this.accCreated = value; }
        }

        public bool DepositAmount(decimal Amount)
        {
            Balance = Balance + Amount;
            Console.WriteLine($"You have Deposited: {Amount}");
            Console.WriteLine($"Your Account Balance: {Balance}");
            return true;
        }
        //Maximum Withdrawal Per Day: 10000
        public bool WithdrawAmount(decimal Amount)
        {
            if (Balance < Amount)
            {
                Console.WriteLine("You have Insufficient balance!");
                return false;
            }
            else if (TodayWithdrawal + Amount > PerDayWithdrawLimit)
            {
                Console.WriteLine("Withdrawal attempt failed!");
                return false;
            }
            else
            {
                Balance = Balance - Amount;
                TodayWithdrawal = TodayWithdrawal + Amount;
                Console.WriteLine($"You have Successfully Withdraw: {Amount}");
                Console.WriteLine($"Your Account Balance: {Balance}");
                return true;
            }
        }
        public decimal CheckBalance()
        {
            return Balance;
        }
    }
    public class CurrentAccount : IBankAccount
    {
        private decimal Balance = 0;

        public DateTime AccCreated => throw new NotImplementedException();

        public bool DepositAmount(decimal Amount)
        {
            Balance = Balance + Amount;
            Console.WriteLine($"You have Deposited: {Amount}");
            Console.WriteLine($"Your Account Balance: {Balance}");
            return true;
        }
        public bool WithdrawAmount(decimal Amount)
        {
            if (Balance < Amount)
            {
                Console.WriteLine("You have Insufficient balance!");
                return false;
            }
            else
            {
                Balance = Balance - Amount;
                Console.WriteLine($"You have Successfully Withdraw: {Amount}");
                Console.WriteLine($"Your Account Balance: {Balance}");
                return true;
            }
        }
        public decimal CheckBalance()
        {
            return Balance;
        }
    }

    /* output
            Console.WriteLine($"Saving Account with account number: {IBankAccount.nextAccountNo()}");   -- Saving Account with account number: 1001
            //A class that implements interface may be implicitly converted to the derived interface or any of its base interfaces.
            IBankAccount savingAccount = new SavingAccount();
            savingAccount.DepositAmount(2000);                                                          -- You have Deposited: 2000 -- Your Account Balance: 2000
            savingAccount.WithdrawAmount(1500);                                                         -- You have Successfully Withdraw: 1500 -- Your Account Balance: 500
            Console.WriteLine($"Saving Account Balanace: {savingAccount.CheckBalance()}");              -- Saving Account Balanace: 500
            
            Console.WriteLine($"\nCurrent Account with account number: {IBankAccount.nextAccountNo()}"); -- Current Account with account number: 1002
            IBankAccount currentAccount = new CurrentAccount();
            currentAccount.DepositAmount(500);                                                          -- You have Deposited: 500 --Your Account Balance: 500
            currentAccount.WithdrawAmount(2600);                                                        -- You have Insufficient balance!
            Console.WriteLine($"Current Account Balanace: {currentAccount.CheckBalance()}");            -- Current Account Balanace: 500
     */

}
