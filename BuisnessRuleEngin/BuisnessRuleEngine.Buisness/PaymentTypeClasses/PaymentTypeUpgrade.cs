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

        private string phoneNumber;
        public PaymentTypeUpgrade() { }

        public override void FillMinDetail(string _name, string _phoneNumber)
        {
            name = _name;
            phoneNumber = _phoneNumber;
        }

        public override void PerformOperations(PaymentDetails paymentDetails)
        {
        }
    }
}
