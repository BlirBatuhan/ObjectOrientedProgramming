class Program
{
    static void Main()
    {
        WeatherForecast forecast = new WeatherForecast();
        List<WeatherData> weatherDataList = new List<WeatherData>();

        // Beş farklı şehir için hava durumu bilgilerini girelim
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Şehir {i} için Hava Durumu Bilgilerini Girin:");
            Console.Write("Şehir Adi: ");
            string city = Console.ReadLine();
            Console.Write("Sicaklik (°C): ");
            double temperature = double.Parse(Console.ReadLine());
            Console.Write("Rüzgar Hizi (km/h): ");
            double windSpeed = double.Parse(Console.ReadLine());
            Console.Write("Nem (%): ");
            double humidity = double.Parse(Console.ReadLine());

            // Hava durumu bilgilerini oluşturup listeye ekleyelim
            WeatherData weatherData = forecast.SetWeather(city, temperature, windSpeed, humidity);
            weatherDataList.Add(weatherData);
        }

        // Girilen hava durumu bilgilerini gösterelim
        Console.WriteLine("\nGirilen Hava Durumu Bilgileri:");
        foreach (var data in weatherDataList)
        {
            Console.WriteLine($"Şehir: {data.City}");
            Console.WriteLine($"Sicaklik: {data.Temperature} °C");
            Console.WriteLine($"Rüzgar Hizi: {data.WindSpeed} km/h");
            Console.WriteLine($"Nem: {data.Humidity}%");
            Console.WriteLine($"Oluşturulma Tarihi: {data.Date}");
            Console.WriteLine("Hava Durumu Açiklamasi: " + forecast.AutoDescription(data.Temperature, data.WindSpeed));
            Console.WriteLine();
        }

       
    }
}
