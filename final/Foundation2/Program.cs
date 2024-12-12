using System;

class Program
{
    static void Main(string[] args)
    {
        Address jeffAddress = new Address("123 Rich st","San Diego", "CA", "US");
        Customer JeffBezos = new Customer("Jeff Bezos",jeffAddress);

        List<Product> firstPurchase = new List<Product>();
        firstPurchase.Add(new Product("Tesla Car","28Z5",29999.99,7));
        firstPurchase.Add(new Product("Apache Attack Helicopter","123A",1500000.50,2));

        Order jeffsOrder = new Order(firstPurchase,JeffBezos);

        Address elonAddress = new Address("843 Swaziland Dr","Durban", "KwaZulu-Natal", "ZA");
        Customer ElonMusk = new Customer("Elon Musk",elonAddress);

        List<Product> secondPurchase = new List<Product>();
        secondPurchase.Add(new Product("Pikmin 4","28JC",60.00,3));
        secondPurchase.Add(new Product("Thor Hammer Replica","TH0R",184.98,5));

        Order elonsOrder = new Order(secondPurchase, ElonMusk);

        Console.WriteLine("Displaying First Order Below:");
        jeffsOrder.DisplayPackingLabel();
        jeffsOrder.DisplayShippingLabel();
        Console.WriteLine($"Total Order Cost: ${jeffsOrder.GetPrice():F2}");

        Console.WriteLine("\nDisplaying Second Order Below:");
        elonsOrder.DisplayPackingLabel();
        elonsOrder.DisplayShippingLabel();
        Console.WriteLine($"Total Order Cost: ${elonsOrder.GetPrice():F2}");

    }
}