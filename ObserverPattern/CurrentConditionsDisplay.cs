using ObserverPattern.Interfaces;

namespace ObserverPattern
{
    internal class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float Temperature { get; set; }
        private float Humidity { get; set; }
        private ISubject WeatherData { get; set; }

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            WeatherData = weatherData;
            WeatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            Temperature = temp;
            Humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current Conditions: {Temperature} degree C and {Humidity}% humidity.");
        }
    }
}
