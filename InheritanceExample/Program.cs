class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hey Bob");
        Person bob = new Person("Bob", "Billy", 37);

        Console.WriteLine(bob.GetPersonInfo());

        Doctor doctorBob = new Doctor("Bob", "Budge", 65, "Hack Saw");
        Console.WriteLine(doctorBob.GetDoctorInformation());
        Console.WriteLine(doctorBob.GetPersonInfo());

        Police policeDoug = new("Doug", "Denver", 40, "Taser");
        Console.WriteLine(policeDoug.GetPoliceInformation());
        Console.WriteLine(policeDoug.GetPersonInfo());
    }
}