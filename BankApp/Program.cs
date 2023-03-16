namespace BankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(00123, "Fan Yang", 1000.00);
            Console.WriteLine("Current balance: {0:C}\n", account.Balance);
            
            Console.WriteLine("Enter an amount to deposit: ");
            double depositAmount = Convert.ToDouble(Console.ReadLine());

            account.Deposit(depositAmount);
            Console.WriteLine("New balance: {0:C}", account.Balance);

            Console.Write("Enter an amount to withdraw: ");
            double withdrawAmount = Convert.ToDouble(Console.ReadLine());

            account.Withdraw(withdrawAmount);
            Console.WriteLine("New balance: {0:C}", account.Balance);

        }
    }
}