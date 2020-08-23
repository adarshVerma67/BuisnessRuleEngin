using BuisnessRuleEngineControllers.Model;
using System;
using System.Collections.Generic;

namespace BuisnessRuleEngin.DB
{
    public class BuisnessRuleEnginDB : IBuisnessRuleEnginDB
    {
        private static List<PaymentDetails> paymentDetails;

        public BuisnessRuleEnginDB()
        {
            paymentDetails = new List<PaymentDetails>();
            paymentDetails.Add(new PaymentDetails
            {
                Name = "Ram",
                Email = "ram@gmail.com",
                Amount = 100,
                PhoneNumber = 999444444,
                TypeofPayment = PaymentTypeEnum.Book,
                AgentName="Mohan",
                Address = new AddressDetails { Address = "RamNagar", DoorNumber = 2, PinCode = "560066" }
            });
            paymentDetails.Add(new PaymentDetails
            {
                Name = "Kris",
                Email = "kris@gmail.com",
                Amount = 100,
                PhoneNumber = 999400000,
                TypeofPayment = PaymentTypeEnum.PhysicalProduct,            
                Address = new AddressDetails { Address = "RRNagar", DoorNumber = 2, PinCode = "560054" }
            });
        }

        public List<PaymentDetails> GetAllPayments()
        {
            return paymentDetails;
        }

        public bool SubmitPayment(PaymentDetails _paymentDetails)
        {
            try
            {
                paymentDetails.Add(_paymentDetails);
                return true;
            }
            catch (Exception)
            {

                throw;
            }

            
        }
    }
}
