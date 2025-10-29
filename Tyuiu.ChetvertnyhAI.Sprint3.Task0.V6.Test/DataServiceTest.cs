using Tyuiu.ChetvertnyhAI.Sprint3.Task0.V6.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint3.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 15;
            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 0.000;
            Assert.AreEqual(wait, res);
        }
    }
}
