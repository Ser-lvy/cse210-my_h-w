public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);

    }
    public double GetTotal()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total+= product.GetTotalCost();
        }
        return total;
    }
    public string GetShippingLabel()
    {
        return _customer.DisplayCustomer();
    }
    public void DisplayOrder()
    {
        Console.WriteLine("ORDER DETAILS");
        Console.WriteLine();
        _customer.DisplayCustomer();
        

        foreach (Product product in _products)
        {
            product.DisplayProduct();
            Console.WriteLine(product.GetPackagingLabel());
            Console.WriteLine();
            

        }
        Console.WriteLine("SHIPPING DETAILS");
        Console.WriteLine(GetShippingLabel());
        Console.WriteLine($"Total: ${GetTotal():0.00}");
    }
    
        

}