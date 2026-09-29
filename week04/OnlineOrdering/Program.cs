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

        Address address2 = new Address("123-C3","New York","New York","USA");
        Customer customer2 = new Customer("Justin",address2);
        Product product3 = new Product("Nike Airforce", "234", 20.00, 3);
        Product product4 = new Product("Adidas Originals Shoes", "598", 25.00, 2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.DisplayOrder();

      
        

        

    }
}