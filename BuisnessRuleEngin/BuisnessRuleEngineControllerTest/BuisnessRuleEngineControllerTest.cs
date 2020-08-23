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
        private Mock<IBuisnessRuleEngineService> buisnessRuleEngineService;
        private BuisnessRuleEngineController buisnessRuleEngineController;

        [SetUp]
        public void Setup()
        {
            buisnessRuleEngineService = new Mock<IBuisnessRuleEngineService>();
            buisnessRuleEngineController = new BuisnessRuleEngineController(buisnessRuleEngineService.Object);
        }

        [Test]
        public void GetAllPaymentsObjectTypeTest()
        {
            var response = buisnessRuleEngineController.GetAllPayments();

            Assert.IsInstanceOf<OkObjectResult>(response);

        }

        [Test]
        public void GetAllPaymentsBadObjectTypeTest()
        {
            buisnessRuleEngineService.Setup(x => x.GetAllPayments()).Throws(new Exception());
            var response = buisnessRuleEngineController.GetAllPayments();

            Assert.IsInstanceOf<BadRequestResult>(response);

        }


        [Test]
        public void SubmitPaymentObjectTypeTest()
        {
            PaymentDetails paymentDetails = new PaymentDetails();
            buisnessRuleEngineService.Setup(x => x.SubmitPayment(paymentDetails)).Returns(true);
            var response = buisnessRuleEngineController.SubmitPayment(paymentDetails);

            Assert.IsInstanceOf<OkObjectResult>(response);

        }

        [Test]
        public void SubmitPaymentBadObjectTypeTest()
        {
            PaymentDetails paymentDetails = new PaymentDetails();
            buisnessRuleEngineService.Setup(x => x.SubmitPayment(paymentDetails)).Throws(new Exception());
            var response = buisnessRuleEngineController.SubmitPayment(paymentDetails);

            Assert.IsInstanceOf<BadRequestResult>(response);

        }
    }
}