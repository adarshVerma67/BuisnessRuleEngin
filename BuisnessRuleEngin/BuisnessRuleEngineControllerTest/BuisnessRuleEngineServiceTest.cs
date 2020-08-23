using BuisnessRuleEngine.Buisness;
using BuisnessRuleEngine.Service;
using BuisnessRuleEngineControllers.Model;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessRuleEngineTest
{
    public class BuisnessRuleEngineServiceTest
    {
        [Test]
        public void GetAllPaymentsObjectTypeTest()
        {
            var buisnessRuleEngineBuisness = new Mock<IBuisnessRuleEngineBuisness>();
            var buisnessRuleEngineService = new BuisnessRuleEngineService(buisnessRuleEngineBuisness.Object);
            var response = buisnessRuleEngineService.GetAllPayments();

            Assert.IsNull(response);

        }

        [Test]
        public void GetAllPaymentsBadObjectTypeTest()
        {
            List<PaymentDetails> response = new List<PaymentDetails>();
            response.Add(new PaymentDetails()
            {
                Name = "Ram",
                Email = "ram@gmail.com",
                Amount = 100,
                PhoneNumber = "999444444",
                TypeofPayment = PaymentTypeEnum.Book,
                AgentName = "Mohan",
                Address = new AddressDetails { Address = "RamNagar", DoorNumber = 2, PinCode = "560066" }
            });

            var buisnessRuleEngineBuisness = new Mock<IBuisnessRuleEngineBuisness>();
            var buisnessRuleEngineService = new BuisnessRuleEngineService(buisnessRuleEngineBuisness.Object);
            buisnessRuleEngineBuisness.Setup(x => x.GetAllPayments()).Returns(response);
            var result = buisnessRuleEngineService.GetAllPayments();

            Assert.IsNotNull(response);
            Assert.AreEqual(response, result);

        }

    }
}
