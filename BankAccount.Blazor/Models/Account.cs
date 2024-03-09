namespace BankAccount.Blazor.Models
{
    public class Account
    {
        // Properties for account number, balance, interest rate, and associated customer
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public double InterestRate { get; set; }
        public Customer Customer { get; set; }

        // Constructor to initialize an account with a customer
        public Account(Customer customer)
        {
            AccountNumber = GenerateAccountNumber(); // Generate a unique account number
            Balance = 0;
            InterestRate = 0.02;
            Customer = customer;
        }

        // Static counter for generating unique account numbers
        private static long accountNumberCounter = 1000000000000000;

        // Method to generate a unique 16-digit account number
        private string GenerateAccountNumber()
        {
            return (accountNumberCounter++).ToString("D16");
        }

        // Method to deposit money into the account
        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C} into account {AccountNumber}. New Balance: {Balance:C}.");
        }

        // Method to withdraw money from the account
        public void Withdraw(decimal amount)
        {
            // Check if withdrawal amount is valid based on account balance
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn {amount:C} from account {AccountNumber}. New Balance: {Balance:C}.");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

    }
}
