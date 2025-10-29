using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ChetvertnyhAI.Sprint3.Task2.V16.Lib
{
    public class DataService : ISprint3Task2V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multSeries = 1;
            do
            {
                multSeries = multSeries * (Math.Pow((1 / Math.Pow(startValue, value)), -1));
                startValue++;
            } while (startValue <= stopValue);
            return multSeries;
        }
    }
}
