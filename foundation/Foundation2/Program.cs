using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        List<Product> products1 = new List<Product>();
        Product p1_1 = new Product("Mac & Cheese", 101, 1.24, 10);
        products1.Add(p1_1);
        Product p1_2 = new Product("Hamburger Patties", 521, 1.89, 16);
        products1.Add(p1_2);
        Product p1_3 = new Product("Hamburger Buns", 522, 3.59, 2);
        products1.Add(p1_3);

        Address address1 = new Address("1234 Street", "Rexburg", "Idaho", "USA");
        Customer customer1 = new Customer("Brodric Young", address1);

        Order o1 = new Order(products1, customer1);
        orders.Add(o1);


        List<Product> products2 = new List<Product>();
        Product p2_1 = new Product("Sandpaper p120 grit", 66895, 0.99, 15);
        products2.Add(p2_1);
        Product p2_2 = new Product("6 in C-clamp", 36479, 2.99, 4);
        products2.Add(p2_2);
        Product p2_3 = new Product("Woodglue", 53987, 4.00, 1);
        products2.Add(p2_3);

        Address address2 = new Address("4321 Avenue", "Lusaka City", "Lusaka", "Zambia");
        Customer customer2 = new Customer("Brody Mufana", address2);

        Order o2 = new Order(products2, customer2);
        orders.Add(o2);



        foreach (Order order in orders) {
            Console.WriteLine("----------------------------------------------------------------\n");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine($"\n{order.GetShippingLabel()}\n");
            Console.WriteLine($"Total Price: ${order.GetTotalCost()}\n");
        }



    }
}