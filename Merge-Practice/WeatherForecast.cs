namespace Merge_Practice
{
    public class WeatherForecast
    {
        public decimal Date { get; set; }

        public decimal TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
