using BuisnessRuleEngineControllers.Model;
using System.Collections.Generic;

namespace BuisnessRuleEngin.DB
{
    public interface IBuisnessRuleEnginDB
    {

        /// <summary>
        /// Gets All Payments
        /// </summary>
        /// <returns>List of Payments</returns>
        List<PaymentDetails> GetAllPayments();

        /// <summary>
        /// Used to submit new Payment
        /// </summary>
        /// <param name="paymentDetails">payment Details</param>
        /// <returns>true/False</returns>
        bool SubmitPayment(PaymentDetails paymentDetails);
    }
}
