public class WeatherData
{
    public double Temperature { get; set; }
    public double Humidity { get; set; }
    public double WindSpeed { get; set; }
    public string City { get; set; }
    public DateTime Date { get; }

    public WeatherData()
    {
        Date = DateTime.Now; 
    }

    public WeatherData(string city, double temperature, double windSpeed, double humidity)
    {
        City = city;
        Temperature = temperature;
        WindSpeed = windSpeed;
        Humidity = humidity;
        Date = DateTime.Now; 
    }
}
