using System;

class Program
{
    static void Main(string[] args)
    {
        
        Address address1 = new Address("Kireka-Kamuli","Kampala","Wakiso","Uganda");
        Customer customer1 = new Customer("Levi Malesh", address1);
        Product product1 = new Product("Nike Mercurial","001", 50.00, 1) ;
        Product product2 = new Product("Adidas F50", "002", 65.00, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        order1.DisplayOrder();

      
        

        

    }
}