using BuisnessRuleEngineControllers.Model;

namespace BuisnessRuleEngine.Service.Classes
{
    public class PaymentTypePhysicalProduct : PaymentTypesBaseClass
    {
        private string name;

        private string phoneNumber;
        public PaymentTypePhysicalProduct() { }

        public override void FillMinDetail(string _name, string _phoneNumber)
        {
            name = _name;
            phoneNumber = _phoneNumber;
        }

        public override void PerformOperations(PaymentDetails paymentDetails)
        {
        }

        private void GeneratePhysicalProductSlips(PaymentDetails paymentDetails)
        {//Generate payment slip 
            base.GeneratePackingSlip(paymentDetails, "Shipping");




        }
    }
}