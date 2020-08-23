using BuisnessRuleEngineControllers.Model;
using System;

namespace BuisnessRuleEngine.Service.Classes
{
    public class PaymentTypeMemberShip : PaymentTypesBaseClass
    {

        private string name;

        private string phoneNumber;
        public PaymentTypeMemberShip() { }

        /// <summary>
        /// Fills Name and phone number
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="phoneNumber">phoneNumber</param>
        public override void FillMinDetail(string _name, string _phoneNumber)
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
            ActivateMembershi(name);
            SendEmail(paymentDetails,"activation");
        }

        /// <summary>
        /// Activates Membership
        /// </summary>
        /// <param name="UserName">UserName</param>
        private void ActivateMembershi(string UserName)
        {
            Console.WriteLine("***********");
            Console.WriteLine("Membership Activated for : {0} ", UserName);
            Console.WriteLine("***********");
                    }

    
    }
}
