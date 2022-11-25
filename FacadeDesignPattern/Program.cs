class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Customer(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }  
}

class BlackListService
{
    public bool CheckEmployeeIsTheBlackList(Customer customer) => true;
}

class CreditCardManager
{
    public void CreateCreditCart(Customer customer)
    {
        
    }
}

class Program
{
    static void Main()
    {
        Customer Customer = new Customer("Resul", "Black");

        CreditCardManager creditCardManager = new CreditCardManager(); ;
        BlackListService blackListService = new BlackListService();

        if (blackListService.CheckEmployeeIsTheBlackList(Customer))
        {
            creditCardManager.CreateCreditCart(Customer);
        }
    }
}