using BuisnessRuleEngineControllers.Model;

namespace BuisnessRuleEngine.Service.Classes
{
    public class PaymentTypeBook : PaymentTypesBaseClass
    {
        private string name;
        private long phoneNumber;

        public PaymentTypeBook() { }

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

        public void GeneratePackingSlip(PaymentDetails paymentDetails)
        {//Generate payment slip 
            base.GeneratePackingSlip(paymentDetails, "Shipping");

            base.GeneratePackingSlip(paymentDetails, "Royality");

        }

        /// <summary>
        /// Performs Payment Type Specific Actions
        /// </summary>
        /// <param name="paymentDetails">paymentDetails</param>
        public override void PerformOperations(PaymentDetails paymentDetails)
        {
            GeneratePackingSlip(paymentDetails);
            GenerateCommission(paymentDetails);
        }
    }
}
