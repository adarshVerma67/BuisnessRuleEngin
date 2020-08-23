using BuisnessRuleEngine.Service.Classes;
using BuisnessRuleEngineControllers.Model;
using System;

namespace BuisnessRuleEngine.Buisness.PaymentTypeClasses
{
    public class PaymentTypeUpgrade : PaymentTypesBaseClass
    {
        private string name;
        private long phoneNumber;
        private readonly string typeOfMembershipPayment;

        public PaymentTypeUpgrade()
        {
            typeOfMembershipPayment = "Update";
        }

        /// <summary>
        /// Fills Name and phone number
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="phoneNumber">phoneNumber</param>
        public override void FillMinDetail(string _name, long _phoneNumber)
        {
            name = _name;
            phoneNumber = _phoneNumber;
        }

        /// <summary>
        /// Performs Payment Type Specific Actions
        /// </summary>
        /// <param name="paymentDetails">paymentDetails</param>
        public override void PerformOperations(PaymentDetails paymentDetails)
        {
            UpGradeMenberShip(name);
            SendEmail(paymentDetails, typeOfMembershipPayment);
        }

        /// <summary>
        /// Updates Membership
        /// </summary>
        /// <param name="UserName">UserName</param>
        private void UpGradeMenberShip(string UserName)
        {
            Console.WriteLine("***********");
            Console.WriteLine("Membership Upgraded for : {0} ", UserName);
            Console.WriteLine("***********");
        }
    }
}
