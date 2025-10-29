using Newtonsoft.Json.Linq;
using System.Collections.Specialized;
using Tyuiu.ChetvertnyhAI.Sprint3.Task3.V10.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint3.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteCharInString()
        {
            DataService ds = new DataService();
            string str = "gdfppf vfppt p";
            char chr = 'p';

            var res = ds.DeleteCharInString(str, chr);
            
            string wait = "gdff vft ";
            Assert.AreEqual(wait, res);
        }
    }
}
