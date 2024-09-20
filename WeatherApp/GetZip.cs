namespace WeatherApp;

public class GetZip
{
    public string ZipCode()
    {
        Console.WriteLine("Please enter your zipcode:");
        var parseSuccess = int.TryParse(Console.ReadLine(), out int userInputZip);

        while (parseSuccess == false || userInputZip.ToString().Length < 5 || userInputZip.ToString().Length > 5)
        {
            Console.WriteLine("Please enter a valid 5-digit zipcode:");
            parseSuccess = int.TryParse(Console.ReadLine(), out userInputZip);
        }

        return userInputZip.ToString();
    }
}