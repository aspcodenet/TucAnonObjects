public class Linq2
{
    public void Uppercase()
    {
        var s = "this IS a STRING of course";
        var uppercases = s.Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Where(e => e == e.ToUpper());
        foreach (var uppercase in uppercases)
            Console.WriteLine(uppercase);


    }



    public void Order()
    {
        string[] cities =
        {
            "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
        };
        var sorted = cities.OrderBy(e => e.Length)
            .ThenByDescending(e=>e);

    }



    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }
    }

    public void Customers()
    {
        var customers = new List<Customer>()
        {
            new Customer() { Name = "Bob Lesman", Balance = 80345.66, Bank = "FTB" },
            new Customer() { Name = "Joe Landy", Balance = 9284756.21, Bank = "WF" },
            new Customer() { Name = "Meg Ford", Balance = 487233.01, Bank = "BOA" },
            new Customer() { Name = "Peg Vale", Balance = 7001449.92, Bank = "BOA" },
            new Customer() { Name = "Mike Johnson", Balance = 790872.12, Bank = "WF" },
            new Customer() { Name = "Les Paul", Balance = 8374892.54, Bank = "WF" },
            new Customer() { Name = "Sid Crosby", Balance = 957436.39, Bank = "FTB" },
            new Customer() { Name = "Sarah Ng", Balance = 56562389.85, Bank = "FTB" },
            new Customer() { Name = "Tina Fey", Balance = 1000000.00, Bank = "CITI" },
            new Customer() { Name = "Sid Brown", Balance = 49582.68, Bank = "CITI" }
        };
        var list = customers.Select(c => new
        {
            Name = c.Name.Split(' ',StringSplitOptions.RemoveEmptyEntries).Last(),
            MoneyToMillion = c.Balance > 1000000 ? 0 : 1000000-c.Balance,
        });
    }


    public void Run()
    {
        Uppercase();
    }
}

