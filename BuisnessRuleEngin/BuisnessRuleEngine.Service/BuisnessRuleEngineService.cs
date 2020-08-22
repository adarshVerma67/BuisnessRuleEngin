using System;
using System.Collections.Generic;
using BuisnessRuleEngine.Buisness;
using BuisnessRuleEngineController.Model;

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
            return buisnessRuleEngineBuisness.GetAllPayments();
        }

        /// <summary>
        /// Used to submit new Payment
        /// </summary>
        /// <param name="paymentDetails">payment Details</param>
        /// <returns>true/False</returns>
        public bool SubmitPayment(PaymentDetails paymentDetails)
        {//validation of general data 
            return buisnessRuleEngineBuisness.SubmitPayment(paymentDetails);
        }
    }
}
