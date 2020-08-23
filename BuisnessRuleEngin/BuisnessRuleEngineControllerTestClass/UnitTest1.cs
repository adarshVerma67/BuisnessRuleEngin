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
            var buisnessRuleEngineService = new Mock<IBuisnessRuleEngineService>();
            var buisnessRuleEngineController = new BuisnessRuleEngineController(buisnessRuleEngineService.Object);
            var result=buisnessRuleEngineController.GetAllPayments();
            Assert.Pass();
        }
    }
}