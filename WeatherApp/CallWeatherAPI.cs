using Newtonsoft.Json.Linq;

namespace WeatherApp;

public class CallWeatherAPI
{
    public void GetWeatherDetails(string zip)
    {
        var apiKey = JObject.Parse(File.ReadAllText("appsettings.json"))["key"].ToString();
        
        try
        {
            var url = 
                $"https://api.openweathermap.org/data/2.5/weather?zip={zip},us&appid={apiKey}&units=imperial";
            
            var weatherApiResponse = new HttpClient().GetStringAsync(url).Result;

            var weatherObject = JObject.Parse(weatherApiResponse);

            Console.WriteLine($"\n" +
                              $"___________________________________________\n" +
                              $"Great! Here are the current weather details\n" +
                              $"for {weatherObject["name"]}...\n" +
                              $"Temperature: {weatherObject["main"]["temp"]} degrees Fahrenheit\n" +
                              $"Real Feel: {weatherObject["main"]["feels_like"]} degrees Fahrenheit\n" +
                              $"Skies: {weatherObject["weather"][0]["description"]}\n" +
                              $"Wind Speed: {weatherObject["wind"]["speed"]} MPH\n" +
                              $"Humidity Level: {weatherObject["main"]["humidity"]}%\n" +
                              $"____________________");
        }
        catch (Exception e)
        {
            Console.WriteLine("Sorry, either that is not a real US zip code,\n" +
                              "or one of our meteorologists had a brain fart.\n" +
                              "Either way, let's give it another shot...");
            new CallWeatherAPI().GetWeatherDetails(new GetZip().ZipCode());
        }
    }
}