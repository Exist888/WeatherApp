namespace WeatherApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n" +
                          "Welcome to Filip's Weather App\n" +
                          "for accurate, real-time weather details\n" +
                          "near you!\n");
        
        new CallWeatherAPI().GetWeatherDetails(new GetZip().ZipCode());
        
        Console.WriteLine("\n" +
                          "Thanks for using our app.\n" +
                          "Come back anytime!");
    }
}