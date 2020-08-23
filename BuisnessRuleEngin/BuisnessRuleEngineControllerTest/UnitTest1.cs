using BuisnessRuleEngin.API.Controllers;
using BuisnessRuleEngine.Service;
using Moq;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var sdsd = new Mock<IBuisnessRuleEngineService>();
             var ssa =new BuisnessRuleEngineController(sdsd.Object);

            var gf= ssa.GetAllPayments();

            Assert.Pass();
        }
    }
}