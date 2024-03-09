namespace BankAccount.Blazor.Models
{
    public class Bank
    {
        // Properties to store the bank name and a list of accounts
        public string Name { get; set; }
        public List<Account> Accounts { get; set; }

        // Constructor to initialize the bank with a name
        public Bank(string name)
        {
            Name = name;
            Accounts = new List<Account>();
        }

    }
}
