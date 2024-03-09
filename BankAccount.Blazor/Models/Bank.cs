namespace BankAccount.Blazor.Models
{
    public class Bank
    {
        // Properties to store the bank name and a list of accounts
        public string BankName { get; set; }
        public List<Account> Accounts { get; set; }

        // Constructor to initialize the bank with a name
        public Bank(string bankName)
        {
            BankName = bankName;
            Accounts = new List<Account>();
        }

        // Method to simulate the process of opening an account

        public void OpenAccount()
        {

            // Prompt the user to enter personal information
            // name of user
            string name = Console.ReadLine();

            string occupation = Console.ReadLine();

            string companyName = Console.ReadLine();

            decimal monthlySalary;
            // Validate and ensure a non-negative monthly salary
            while (!decimal.TryParse(Console.ReadLine(), out monthlySalary) || monthlySalary < 0)
            {
                Console.Write("Invalid input. Please enter a valid monthly salary: ");
            }

            
            int age;
            // Validate and ensure the user is 18 or older
            while (!int.TryParse(Console.ReadLine(), out age) || age < 18)
            {
                Console.Write("Invalid input. Please enter a valid age (must be 18 or older): ");
            }

            
            string emailAddress = Console.ReadLine();

            
            string address = Console.ReadLine();

            
            string mobileNumber = Console.ReadLine(); 

            // Check if salary is less than 5000, deny account opening if true
            if (monthlySalary < 5000)
            {
                Console.WriteLine("Account opening request turned down. Monthly salary must be 5000 or more.");
                return;
            }

            // Create a Customer object with the provided information
            Customer customer = new Customer(name, occupation, companyName, monthlySalary, age, emailAddress, address, mobileNumber);

            

            // Open an account with initial balance set to the monthly salary
            Account myAccount = new Account(customer);
            Accounts.Add(myAccount);

            // Display success message and customer information
            
            customer.DisplayCustomerInfo();
            

            // Allow the user to perform deposit or withdrawal operations in a loop
            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Exit");

                int choice;
                // Validate and ensure a valid option is selected
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
                {
                    Console.Write("Invalid input. Please enter a valid option: ");
                }

                // Switch statement to handle user's choice
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the amount to deposit: ");
                        decimal depositAmount;
                        // Validate and ensure a non-negative deposit amount
                        while (!decimal.TryParse(Console.ReadLine(), out depositAmount) || depositAmount < 0)
                        {
                            Console.Write("Invalid input. Please enter a valid deposit amount: ");
                        }
                        myAccount.Deposit(depositAmount);
                        Console.WriteLine($"Deposit completed. New Balance: {myAccount.Balance:C}");
                        break;
                    case 2:
                        Console.Write("Enter the amount to withdraw: ");
                        decimal withdrawAmount;
                        // Validate and ensure a non-negative withdrawal amount
                        while (!decimal.TryParse(Console.ReadLine(), out withdrawAmount) || withdrawAmount < 0)
                        {
                            Console.Write("Invalid input. Please enter a valid withdrawal amount: ");
                        }
                        // Check if withdrawal amount is valid based on account balance
                        if (myAccount.Balance >= withdrawAmount)
                        {
                            myAccount.Withdraw(withdrawAmount);
                            Console.WriteLine($"Withdrawal completed. New Balance: {myAccount.Balance:C}");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient funds. Withdrawal request denied.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        return;
                }
            }
        }

    }  
}
