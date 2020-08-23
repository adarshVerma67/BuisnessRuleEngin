using BuisnessRuleEngine.Buisness;
using BuisnessRuleEngine.Service;
using BuisnessRuleEngineControllers.Model;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;


namespace BuisnessRuleEngineTest
{
    public class BuisnessRuleEngineServiceTest
    {
        private Mock<IBuisnessRuleEngineBuisness> buisnessRuleEngineBuisness;
        private BuisnessRuleEngineService buisnessRuleEngineService;
        [SetUp]
        public void Setup()
        {
            buisnessRuleEngineBuisness = new Mock<IBuisnessRuleEngineBuisness>();
            buisnessRuleEngineService = new BuisnessRuleEngineService(buisnessRuleEngineBuisness.Object);
        }
        
        [Test]
        public void GetAllPaymentsNullTest()
        {
            var response = buisnessRuleEngineService.GetAllPayments();

            Assert.IsNull(response);
        }

        [Test]
        public void GetAllPaymentsValueTest()
        {
            List<PaymentDetails> response = new List<PaymentDetails>();
            response.Add(new PaymentDetails()
            {
                Name = "Ram",
                Email = "ram@gmail.com",
                Amount = 100,
                PhoneNumber = 999444444,
                TypeofPayment = PaymentTypeEnum.Book,
                AgentName = "Mohan",
                Address = new AddressDetails { Address = "RamNagar", DoorNumber = 2, PinCode = "560066" }
            });

            buisnessRuleEngineBuisness.Setup(x => x.GetAllPayments()).Returns(response);
            var result = buisnessRuleEngineService.GetAllPayments();

            Assert.IsNotNull(response);
            Assert.AreEqual(response, result);
        }

        [Test]
        public void SubmitPaymentNullTest()
        {
            var result = buisnessRuleEngineService.SubmitPayment(new PaymentDetails());

            Assert.False(result);
        }

        [Test]
        public void SubmitPaymentTrueTest()
        {
            PaymentDetails paymentDetails = new PaymentDetails()
            {
                Name = "Ram",
                Email = "ram@gmail.com",
                Amount = 100,
                PhoneNumber = 999444444,
                TypeofPayment = PaymentTypeEnum.Book,
                AgentName = "Mohan",
                Address = new AddressDetails { Address = "RamNagar", DoorNumber = 2, PinCode = "560066" }
            };

            buisnessRuleEngineBuisness.Setup(x => x.SubmitPayment(paymentDetails)).Returns(true);
            var result = buisnessRuleEngineService.SubmitPayment(paymentDetails);

            Assert.True(result);
        }

        static readonly object[] request =
            {
        new object[] { new PaymentDetails()
        {
            Name = null,
            Email = "ram@gmail.com",
            Amount = 100,
            PhoneNumber = 999444444,
            TypeofPayment = PaymentTypeEnum.Book,
            AgentName = "Mohan",
            Address = new AddressDetails { Address = "RamNagar", DoorNumber = 2, PinCode = "560066" }
        },false
        },
        new object[] { new PaymentDetails()
        {
            Name = "Ram",
            Email = "ram@gmail.com",
            Amount = 0,
            PhoneNumber = 999444444,
            TypeofPayment = PaymentTypeEnum.Book,
            AgentName = "Mohan",
            Address = new AddressDetails { Address = "RamNagar", DoorNumber = 2, PinCode = "560066" }
        },false
        },
        new object[] { new PaymentDetails()
        {
            Name = "Ram",
            Email = "ram@gmail.com",
            Amount = 100,
            PhoneNumber = 999444444,
            TypeofPayment = PaymentTypeEnum.Book,
            AgentName = "Mohan",
            Address = new AddressDetails { Address = "RamNagar", DoorNumber = 2, PinCode = "560066" }
        },false
       },
       new object[] { new PaymentDetails()
        {
            Name = "Ram",
            Email = null,
            Amount = 100,
            PhoneNumber = 999444444,
            TypeofPayment = PaymentTypeEnum.Book,
            AgentName = "Mohan",
            Address = new AddressDetails { Address = "RamNagar", DoorNumber = 2, PinCode = "560066" }
        },false
       }
    };


        [TestCaseSource("request")]
        public void SubmitPaymentFalseValueTest(PaymentDetails request, bool expectedResult)
        {
            var actualResult = buisnessRuleEngineService.SubmitPayment(request);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
