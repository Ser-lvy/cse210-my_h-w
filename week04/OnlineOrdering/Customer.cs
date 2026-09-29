public class Customer
{
    private string _nameOfCustomer;
    private Address _address;

    public Customer(string nameOfCustomer, Address address)
    {
        _nameOfCustomer = nameOfCustomer;
        _address = address;

    }
    public string DisplayCustomer()
    {
        return $"Customer: {_nameOfCustomer}\nAddress: {_address.GetFullAddress()}";
        

    }
}
