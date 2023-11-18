public class WeatherForecast{
    public string AutoDescription(double temperature, double windSpeed){
        string description = "";

    if (temperature >= 30.0 && windSpeed < 10.0)
    {
        description = "Hot and Calm";
    }
    else if (temperature >= 20.0 && windSpeed >= 10.0)
    {
        description = "Hot and Windy";
    }
    else if (temperature >= 10.0 && windSpeed < 10.0)
    {
        description = "Pleasant and Calm";
    }
    else if (temperature <= 0.0)
    {
        description = "Snowy and Rainy";
    }
    else
    {
        description = "Weather conditions are not defined for these values.";
    }

    return description;

    }
    public void GetWeatherForecast(){

    }
    public WeatherData SetWeather(string city, double temperature, double windSpeed, double humidity)
{
    // Hava durumu raporu oluşturuluyor
    WeatherData data = new WeatherData(city, temperature, windSpeed, humidity);
    
    // Hava durumu raporu döndürülüyor
    return data;
}

}