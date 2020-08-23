using BuisnessRuleEngineControllers.Model;

namespace BuisnessRuleEngine.Service.Classes
{
    public class PaymentTypeBook : PaymentTypesBaseClass
    {
        private string name;

        private string phoneNumber;
        public PaymentTypeBook() { }

        public override void FillMinDetail(string _name, string _phoneNumber)
        {
            name = _name;
            phoneNumber = _phoneNumber;
        }

        public void GeneratePackingSlip(PaymentDetails paymentDetails)
        {//Generate payment slip 
            base.GeneratePackingSlip(paymentDetails, "Shipping");

            base.GeneratePackingSlip(paymentDetails, "Royality");

        }

        public override void PerformOperations(PaymentDetails paymentDetails)
        {
        }
    }
}
