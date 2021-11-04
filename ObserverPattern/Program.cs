namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = new WeatherProvider();
            var observer1 = new WeatherObserver("TP");
            var observer2 = new WeatherObserver("H");
            provider.WeatherConditions(32.0, 0.05, 1.5);
            observer1.Subscribe(provider);
            provider.WeatherConditions(33.5, 0.04, 1.7);
            observer2.Subscribe(provider);
            provider.WeatherConditions(37.5, 0.07, 1.2);
        }
    }
}
