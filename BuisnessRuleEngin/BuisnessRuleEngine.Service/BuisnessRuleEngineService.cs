using BuisnessRuleEngine.Buisness;
using BuisnessRuleEngineControllers.Model;
using System;
using System.Collections.Generic;

namespace BuisnessRuleEngine.Service
{
    public class BuisnessRuleEngineService : IBuisnessRuleEngineService
    {
        private readonly IBuisnessRuleEngineBuisness buisnessRuleEngineBuisness;

        public BuisnessRuleEngineService(IBuisnessRuleEngineBuisness _buisnessRuleEngineBuisness)
        {
            buisnessRuleEngineBuisness = _buisnessRuleEngineBuisness;
        }

        /// <summary>
        /// Gets All Payments
        /// </summary>
        /// <returns>List of Payments</returns>
        public List<PaymentDetails> GetAllPayments()
        {
            try
            {
                return buisnessRuleEngineBuisness.GetAllPayments();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Used to submit new Payment
        /// </summary>
        /// <param name="paymentDetails">payment Details</param>
        /// <returns>true/False</returns>
        public bool SubmitPayment(PaymentDetails paymentDetails)
        {
            try
            {
                return IsDataValid(paymentDetails) ? buisnessRuleEngineBuisness.SubmitPayment(paymentDetails) : false; ;
            }
            catch (Exception)
            {
                throw;
            }

        }

        private bool IsDataValid(PaymentDetails paymentDetails)
        {
            bool valid = true;
            //validation of data  
            if (paymentDetails == null)
            {
                valid = false;
            }
            else if (paymentDetails.Name == null || paymentDetails.Amount == 0 || paymentDetails.Email == null ||
                paymentDetails.PhoneNumber <=0)
            {
                valid = false;
            }

            return valid;
        }
    }
}
