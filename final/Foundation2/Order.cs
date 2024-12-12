using System.Net.Http.Headers;
using System.Runtime.InteropServices.Marshalling;

class Order
{
    private List<Product> products;
    private Dictionary<string,string> packingLabel = new Dictionary<string, string>();
    private (string,string) shippingLabel;
    private Customer customer;
    private double totalPrice;
    private int shippingPrice;
    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
        FindShipping();
        calcPrice();
        SetPackingLabel();
        SetShippingLabel();
    }

    public void calcPrice()
    {
        totalPrice = 0;
        foreach(Product product in products)
        {
            totalPrice += product.TotalPrice();
        }
        totalPrice += shippingPrice;
        
    }

    public void FindShipping()
    {
        if(customer.GetAddress().LivesUSA())
        {
            shippingPrice = 5;
        }
        else{
            shippingPrice = 35;
        }
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine("Packing Labels For Each Product");
        foreach(KeyValuePair<string,string> label in packingLabel)
        {
            Console.WriteLine($" Packing Label:\n  Name: {label.Key} ID: {label.Value}");
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("Shipping Label:");
        Console.WriteLine($"  Customer Name: {shippingLabel.Item1}\n  Address: {shippingLabel.Item2}");
    }

    public void SetPackingLabel()
    {
        
        foreach(Product product in products)
        {
            packingLabel[product.GetName()] = product.GetID();
            
        }
    }

    public void SetShippingLabel()
    {
        shippingLabel = (customer.GetName(),customer.GetAddress().WholeAddress());
        
        
    }

    public double GetPrice()
    {
        return totalPrice;
    }

}