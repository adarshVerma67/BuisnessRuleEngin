using BuisnessRuleEngin.DB;
using BuisnessRuleEngine.Buisness;
using BuisnessRuleEngineControllers.Model;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessRuleEngineTest
{
  public  class BuisnessRuleEngineBuisnessTest
    {
        private Mock<IBuisnessRuleEnginDB> buisnessRuleEngineDB;
        private BuisnessRuleEngineBuisness buisnessRuleEngineBuisness;
        [SetUp]
        public void Setup()
        {
            buisnessRuleEngineDB = new Mock<IBuisnessRuleEnginDB>();
            buisnessRuleEngineBuisness = new BuisnessRuleEngineBuisness(buisnessRuleEngineDB.Object);
        }



        static readonly object[] request =
       {
        new object[] { new PaymentDetails()
        {
            Name = null,
            Email = "ram@gmail.com",
            Amount = 100,
            PhoneNumber = "999444444",
            TypeofPayment = PaymentTypeEnum.PhysicalProduct,
            AgentName = "Mohan",
            Address = new AddressDetails { Address = "RamNagar", DoorNumber = 2, PinCode = "560066" }
        },true
        },
        new object[] { new PaymentDetails()
        {
            Name = "Ram",
            Email = "ram@gmail.com",
            Amount = 10,
            PhoneNumber = "999444444",
            TypeofPayment = PaymentTypeEnum.Book,
            AgentName = "Mohan",
            Address = new AddressDetails { Address = "RamNagar", DoorNumber = 2, PinCode = "560066" }
        },true
        },
        new object[] { new PaymentDetails()
        {
            Name = "Ram",
            Email = "ram@gmail.com",
            Amount = 100,
            PhoneNumber = null,
            TypeofPayment = PaymentTypeEnum.LearningToSki,
            AgentName = "Mohan",
            Address = new AddressDetails { Address = "RamNagar", DoorNumber = 2, PinCode = "560066" }
        },true
       },
           new object[] { new PaymentDetails()
        {
            Name = "Ram",
            Email = "ram@gmail.com",
            Amount = 100,
            PhoneNumber = "999444444",
            TypeofPayment = PaymentTypeEnum.MemberShip,
            AgentName = "Mohan",
            Address = new AddressDetails { Address = "RamNagar", DoorNumber = 2, PinCode = "560066" }
        },true
       },
       new object[] { new PaymentDetails()
        {
            Name = "Ram",
            Email = "ram@gmail.com",
            Amount = 100,
            PhoneNumber = "999444444",
            TypeofPayment = PaymentTypeEnum.Upgrade,
            AgentName = "Mohan",
            Address = new AddressDetails { Address = "RamNagar", DoorNumber = 2, PinCode = "560066" }
        },true
       }
    };


        [TestCaseSource("request")]
        public void SubmitPaymentValueTest(PaymentDetails paymentDetails, bool expectedResult)
        {
            buisnessRuleEngineDB.Setup(x => x.SubmitPayment(paymentDetails)).Returns(true);
            var actualResult = buisnessRuleEngineBuisness.SubmitPayment(paymentDetails);

            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestCaseSource("request")]
        public void SubmitPaymentFalseValueTest(PaymentDetails paymentDetails, bool expectedResul)
        {
            buisnessRuleEngineDB.Setup(x => x.SubmitPayment(paymentDetails)).Returns(false);
            var actualResult = buisnessRuleEngineBuisness.SubmitPayment(paymentDetails);

            Assert.AreEqual(false, actualResult);
        }
    }
}
