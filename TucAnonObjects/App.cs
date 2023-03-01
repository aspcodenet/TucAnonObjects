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
        Lab1();
    }
}