using BuisnessRuleEngineControllers.Model;

namespace BuisnessRuleEngine.Service.Classes
{
    public class PaymentTypePhysicalProduct : PaymentTypesBaseClass
    {
        private string name;

        private string phoneNumber;
        public PaymentTypePhysicalProduct() { }

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
            base.GeneratePackingSlip(paymentDetails, "Shipping");
            GenerateCommission(paymentDetails);
        }
    }
}