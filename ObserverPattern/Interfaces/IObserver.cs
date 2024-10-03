namespace ObserverPattern.Interfaces
{
    internal interface IObserver
    {
        public void Update(float temp, float humidity, float pressure);
    }
}
