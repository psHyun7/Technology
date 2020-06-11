using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class UnitTest1
    { 
        Computer test_computer;
        Laptop test_laptop;
        SmartPhone test_smartphone;

        [TestInitialize]
        test_computer = new Computer("Windows", true, 1024);


        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
