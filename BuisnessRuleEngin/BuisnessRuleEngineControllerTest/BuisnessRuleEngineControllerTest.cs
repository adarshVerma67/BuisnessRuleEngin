using BuisnessRuleEngin.API.Controllers;
using BuisnessRuleEngine.Service;
using BuisnessRuleEngineControllers.Model;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetAllPaymentsObjectTypeTest()
        {
            var buisnessRuleEngineService = new Mock<IBuisnessRuleEngineService>();
            var buisnessRuleEngineController = new BuisnessRuleEngineController(buisnessRuleEngineService.Object);
            var response = buisnessRuleEngineController.GetAllPayments();

            Assert.IsInstanceOf<OkObjectResult>(response);

        }

        [Test]
        public void GetAllPaymentsBadObjectTypeTest()
        {
            var buisnessRuleEngineService = new Mock<IBuisnessRuleEngineService>();
            var buisnessRuleEngineController = new BuisnessRuleEngineController(buisnessRuleEngineService.Object);
            buisnessRuleEngineService.Setup(x => x.GetAllPayments()).Throws(new Exception());
            var response = buisnessRuleEngineController.GetAllPayments();

            Assert.IsInstanceOf<BadRequestResult>(response);

        }


        [Test]
        public void SubmitPaymentObjectTypeTest()
        {
            PaymentDetails paymentDetails = new PaymentDetails();
            var buisnessRuleEngineService = new Mock<IBuisnessRuleEngineService>();
            var buisnessRuleEngineController = new BuisnessRuleEngineController(buisnessRuleEngineService.Object);
            buisnessRuleEngineService.Setup(x => x.SubmitPayment(paymentDetails)).Returns(true);
            var response = buisnessRuleEngineController.SubmitPayment(paymentDetails);

            Assert.IsInstanceOf<OkObjectResult>(response);

        }

        [Test]
        public void SubmitPaymentBadObjectTypeTest()
        {
            PaymentDetails paymentDetails = new PaymentDetails();
            var buisnessRuleEngineService = new Mock<IBuisnessRuleEngineService>();
            var buisnessRuleEngineController = new BuisnessRuleEngineController(buisnessRuleEngineService.Object);
            buisnessRuleEngineService.Setup(x => x.SubmitPayment(paymentDetails)).Throws(new Exception());
            var response = buisnessRuleEngineController.SubmitPayment(paymentDetails);

            Assert.IsInstanceOf<BadRequestResult>(response);

        }
    }
}