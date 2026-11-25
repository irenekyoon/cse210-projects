using System;

class Program
{
    static void Main(string[] args)
    {
        // code for Vehicle
        Console.WriteLine("Learning about base dot, virtual/override, and base dot inside override");
        List<Vehicle> vehicles = new List<Vehicle>();
        Bicycle bike = new Bicycle("Trail Bike", 30);
        Truck truck = new Truck("Hauler", 90, 5000);
        Vehicle vehicle = new Vehicle("Generic", 50);
        vehicles.Add(bike);
        vehicles.Add(truck);
        vehicles.Add(vehicle);

        foreach (Vehicle v in vehicles)
        {
            Console.WriteLine(v.Describe());
        }
        Console.WriteLine(bike.ParentVersion());
        
        // code for Flower
        // Rose rose = new Rose("pink", 5);
        // Console.WriteLine(rose.Describe());
        // Flower f = rose;
        // Console.WriteLine(f.Describe());

        // Rose rose2 = new Rose("yellow", 2);
        // //Console.WriteLine(rose2.GetColor());
        // Console.WriteLine(rose2.Describe());
        // Console.WriteLine();

        // List<Flower> flowers = new List<Flower>();
        // flowers.Add(new Rose("white", 4)); // 'override' will give the description of thorns. 'new' won't
        // flowers.Add(new Flower("purple"));
        // foreach (Flower flower in flowers)
        // {
        //     Console.WriteLine(flower.Describe());
        // }

        // code for Fraction2

        // Fraction fraction = new Fraction(5, 4);
        // try
        // {
        //     Console.WriteLine(fraction.GetFractionString());
        //     int bottom = fraction.GetBottom();
        //     Console.WriteLine(bottom);
        //     fraction.SetBottom(0);
        //     Console.WriteLine($"First fraction string: {fraction.GetFractionString()}");
        // }
        // catch (ArgumentException e)
        // {
        //     Console.WriteLine(e.Message);
        // }
        // Console.WriteLine($"Second fraction string: {fraction.GetFractionString()}");

        // // Fraction fraction = new Fraction();
        // // Fraction fraction2 = new Fraction(5);
        // // Fraction fraction3 = new Fraction(3, 5);
        // Fraction wholeNum = new Fraction();
        // Console.WriteLine(wholeNum.GetFractionString());
        // Console.WriteLine(wholeNum.GetDecimalValue());

        // Fraction wholeNum2 = new Fraction(5);
        // Console.WriteLine(wholeNum2.GetFractionString());
        // Console.WriteLine(wholeNum2.GetDecimalValue());

        // Fraction wholeNum3 = new Fraction(1, 3);
        // Console.WriteLine(wholeNum3.GetFractionString());
        // Console.WriteLine(wholeNum3.GetDecimalValue());

        // Fraction fraction = new Fraction();
        // fraction.SetTop(5);
        // Console.WriteLine(fraction.GetTop());

        // code for the PlaylistBuilder.cs
        // Song song1 = new Song("Praise to the Man", "William Phelps", "100");
        // Song song2 = new Song("The Spirit of God", "William Phelps", "200");
        // Song song3 = new Song("I am a Child of God", "Naomi Ward Randall", "301");
        // song2.DisplaySong();
        // Playlist playlist = new Playlist("Favorite Hymns");
        // playlist.AddSong(song1);
        // playlist.AddSong(song2);
        // playlist.AddSong(song3);
        // playlist(song2);
        // playlist(song3);
        // playlist._playlistName = "Favorite Hymns";
        // playlist.DisplayPlaylist();
        // Console.WriteLine();
        // playlist.DisplayPlaylist();

        // code for the Book.cs
        // Book book = new Book("Emma", "Ausen", 0);
        // Console.Write(book);

    }
}
