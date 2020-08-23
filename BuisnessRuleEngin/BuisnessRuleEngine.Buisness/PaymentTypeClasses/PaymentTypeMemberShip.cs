using BuisnessRuleEngineControllers.Model;
using System;

namespace BuisnessRuleEngine.Service.Classes
{
    public class PaymentTypeMemberShip : PaymentTypesBaseClass
    {

        private string name;

        private string phoneNumber;
        public PaymentTypeMemberShip() { }

        public override void FillMinDetail(string _name, string _phoneNumber)
        {
            name = _name;
            phoneNumber = _phoneNumber;
        }

        public override void PerformOperations(PaymentDetails paymentDetails)
        {
        }

        private void SendEmail(PaymentDetails paymentDetails)
        {//Generate payment slip 
            Console.WriteLine("Email Generated for \\n Name :{0}\\n Amount :{1}\\n Email :{2}",
                paymentDetails.Name, paymentDetails.Amount, paymentDetails.Email);
        }
    }
}
