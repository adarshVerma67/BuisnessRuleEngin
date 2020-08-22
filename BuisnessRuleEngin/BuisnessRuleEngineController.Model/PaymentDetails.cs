using System;

namespace BuisnessRuleEngineController.Model
{
    public class PaymentDetails
    {
        public int Amount { get; set; }

        public String Name { get; set; }

        public AddressDetails Address { get; set; }

        public String Email { get; set; }

        public String PhoneNumber { get; set; }

        public String AgentName { get; set; }


        public PaymentTypeEnum TypeofPayment { get; set; }
        


    }
}
