class Address{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
        LivesUSA();
    }

    public bool LivesUSA()
    {
        if(country == "US")
        {
            return true;
        }
        else if(country == "United States")
        {
            return true;
        }
        else{
            return false;
        }
    }

    public string WholeAddress()
    {
        string address = $"{street}, {city}, {state}, {country}";
        return address;
    }
}