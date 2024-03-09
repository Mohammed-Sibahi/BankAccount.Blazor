namespace BankAccount.Blazor.Models
{
    public class Customer
    {
        // Properties for customer ID and personal information
        public int CustomerId { get; private set; }
        public string Name { get; private set; }
        public string Occupation { get; private set; }
        public string CompanyName { get; private set; }
        public decimal MonthlySalary { get; private set; }
        public int Age { get; private set; }
        public string EmailAddress { get; private set; }
        public string Address { get; private set; }
        public string MobileNumber { get; private set; }

        // Constructor to initialize a customer with personal information
        public Customer(string name, string occupation, string companyName, decimal monthlySalary, int age, string emailAddress, string address, string mobileNumber)
        {
            CustomerId = GenerateCustomerId(); // Generate a unique customer ID
            Name = name;
            Occupation = occupation;
            CompanyName = companyName;
            MonthlySalary = monthlySalary;
            Age = age;
            EmailAddress = emailAddress;
            Address = address;
            MobileNumber = mobileNumber;
        }

        // Static counter for generating unique customer IDs
        private static int customerIdCounter = 1;

        // Method to generate a unique customer ID
        private int GenerateCustomerId()
        {
            return customerIdCounter++;
        }

        // Method to display customer information
        public void DisplayCustomerInfo()
        {
            Console.WriteLine($"Customer ID: {CustomerId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Occupation: {Occupation}");
            Console.WriteLine($"Company: {CompanyName}");
            Console.WriteLine($"Monthly Salary: {MonthlySalary:C}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Email Address: {EmailAddress}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Mobile Number: {MobileNumber}");
        }

    }
}
