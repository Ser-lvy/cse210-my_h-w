public class Customer
{
    private string _nameOfCustomer;
    private Address _address;

    public Customer(string nameOfCustomer, Address address)
    {
        _nameOfCustomer = nameOfCustomer;
        _address = address;

    }
    public void DisplayCustomer()
    {
        Console.WriteLine($"Customer: {_nameOfCustomer}");
        Console.WriteLine($"Address: {_address.GetFullAddress()}");

    }
}
