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
    public void DisplayOrder()
    {
        _customer.DisplayCustomer();
        Console.WriteLine("Products:");

        foreach (Product product in _products)
        {
            product.DisplayProduct();

        }
        Console.WriteLine($"Total: ${GetTotal():0.00}");
    }
    
        

}