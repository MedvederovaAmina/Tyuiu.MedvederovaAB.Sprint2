using Tyuiu.MedvederovaAB.Sprint2.Task4.V21.Lib;

namespace Tyuiu.MedvederovaAB.Sprint2.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 157.276;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
           DataService ds = new DataService();
            double x = 6;
            double y = 5;
            double res = 1.211;
            double wait = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}