using CodeLouisvilleArrayPractice;

namespace ArrayPracticeTests
{
    [TestClass]
    public class BusRouteTests
    {
        [TestInitialize]
        public void Setup()
        {
            //Do some setup
        }

        [TestMethod]
        public void BusRouteConstructorTest()
        {
            BusRoute busRoute = new BusRoute(1, "test", "test");
            Assert.IsNotNull(busRoute);
        }

        [TestMethod]
        public void SomeTest2()
        {
            Assert.Equals(true, true);
        }
    }
}