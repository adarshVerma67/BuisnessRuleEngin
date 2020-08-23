using System;
using System.ComponentModel.DataAnnotations;

namespace BuisnessRuleEngineControllers.Model
{
    public class PaymentDetails
    {
        [Required]
        public int Amount { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public AddressDetails Address { get; set; }

        [Required]
        public String Email { get; set; }

        [Required]
        public long PhoneNumber { get; set; }

        public String AgentName { get; set; }

        [Required]
        public PaymentTypeEnum TypeofPayment { get; set; }



    }
}
