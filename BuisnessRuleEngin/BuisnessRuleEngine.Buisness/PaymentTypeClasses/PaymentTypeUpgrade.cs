using BuisnessRuleEngine.Service.Classes;
using BuisnessRuleEngineControllers.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessRuleEngine.Buisness.PaymentTypeClasses
{
  public  class PaymentTypeUpgrade : PaymentTypesBaseClass
    {
        private string name;

        private long phoneNumber;
        public PaymentTypeUpgrade() { }

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
            SendEmail(paymentDetails, "Update");
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
