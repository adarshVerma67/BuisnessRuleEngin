using BuisnessRuleEngine.Service.Classes;
using BuisnessRuleEngineControllers.Model;
using Console = System.Diagnostics.Debug;

namespace BuisnessRuleEngine.Buisness.PaymentTypeClasses
{
    public class PaymentTypeLearningToSki : PaymentTypesBaseClass
    {
        private string name;

        private long phoneNumber;
        public PaymentTypeLearningToSki() { }

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
            AddFirstAidVideo(paymentDetails.Email);
        }

        /// <summary>
        /// Add free first Aid Video
        /// </summary>
        /// <param name="email"></param>
        private void AddFirstAidVideo(string email)
        {
            Console.WriteLine("***********");
            Console.WriteLine("Free first Aid Video Added");
            Console.WriteLine("***********");
        }
    }
}
