public class App
{
    public void Lab1()
    {
        var annons = new
        {
            EndDate=DateTime.Now.AddDays(30),
            Seller="Stefan Holmberg",
            Title="Playstation 5",
            Beskrivning="Nästan oanvänd",
            Price=5500
        };

    }

    public void Lab2()
    {
        var annons = new
        {
            EndDate = DateTime.Now.AddDays(30),
            Seller = "Stefan Holmberg",
            Title = "Playstation 5",
            Beskrivning = "Nästan oanvänd",
            Price = 5500,
            Bids = new[]
            {
                new
                {
                    Name="Kalle",
                    Date =new DateTime(2022,11,5),
                    Price=2100
                },
                new
                {
                    Name="Lisa",
                    Date =new DateTime(2022,11,6),
                    Price=2200
                }

            }
        };

    }


    public void Run()
    {
        var l = new Linq2();
        l.Run();
        Lab1();
    }

    public int RabattPercent()
    {
        if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            return 10;
        return 0;
    }
    public void Run2()
    {

        var annons2 = new
        {
            Seller = "Stefan Holmberg",
            Title = "Playstation 5",
            Description = "Nästan oanvänd",
            Price = 100m,
            Created = DateTime.Now,
            EndDate = DateTime.Now.AddDays(30),
            Rabatt = RabattPercent(),
        };












        var annons = new
        {
            Seller = "Stefan Holmberg",
            Title = "Playstation 5",
            Description="Nästan oanvänd",
            Price = 100m,
            Created = DateTime.Now,
            EndDate = DateTime.Now.AddDays(30),
            Rabatt = RabattPercent(),
            Bids = new []
            {
                new
                {
                    Namn = "Rickard",
                    Date = new DateTime(2023,02,28,10,23,18),
                    Bid = 200m
                },
                new
                {
                    Namn = "Aron",
                    Date = new DateTime(2023,02,28,11,23,18),
                    Bid = 300m
                },

            }
        };
        Console.WriteLine($"Hej {annons.Seller} {annons.Title}");
        //
        //annons.Seller = "34234423";
    }
}