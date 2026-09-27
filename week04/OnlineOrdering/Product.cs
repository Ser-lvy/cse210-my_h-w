public class Product
{
    private string _nameOfProduct;
    private string _idOfProduct;
    private double _priceOfProduct;
    private int _quantityOfProduct;

    public Product(string nameOfProduct, string idOfProduct, double priceOfProduct, int quantityOfProduct)
    {
        _nameOfProduct = nameOfProduct;
        _idOfProduct = idOfProduct;
        _priceOfProduct = priceOfProduct;
        _quantityOfProduct = quantityOfProduct;
        
    }
    public double GetTotalCost()
    {
        return _priceOfProduct*_quantityOfProduct;
    }
    public string GetNameOfProduct()
    {
        return _nameOfProduct;
    }
    public string GetIdOfProduct()
    {
       return _idOfProduct; 
    }
    public void DisplayProduct()
    {
        Console.WriteLine($"Product: {_nameOfProduct}");
        Console.WriteLine($"Product ID: {_idOfProduct}");
        Console.WriteLine($"Price:  ${_priceOfProduct: 0.00}");
        Console.WriteLine($"Quantity: {_quantityOfProduct}");
        Console.WriteLine($"Total: ${GetTotalCost():0.00}");
    }
}