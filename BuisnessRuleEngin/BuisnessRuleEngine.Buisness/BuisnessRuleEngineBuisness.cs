using System;
using System.Collections.Generic;
using BuisnessRuleEngin.DB;
using BuisnessRuleEngineControllers.Model;

namespace BuisnessRuleEngine.Buisness
{
    public class BuisnessRuleEngineBuisness : IBuisnessRuleEngineBuisness
    {
        private readonly IBuisnessRuleEnginDB buisnessRuleEngineDB;

        public BuisnessRuleEngineBuisness(IBuisnessRuleEnginDB _buisnessRuleEngineDB)
        {
            buisnessRuleEngineDB = _buisnessRuleEngineDB;
        }

        /// <summary>
        /// Gets All Payments
        /// </summary>
        /// <returns>List of Payments</returns>
        public List<PaymentDetails> GetAllPayments()
        {
            return buisnessRuleEngineDB.GetAllPayments();
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
                bool insertStatus = buisnessRuleEngineDB.SubmitPayment(paymentDetails);
                if (insertStatus)
                {
                    //process different types of payment
                }

                return insertStatus;

            }
            catch (Exception)
            {

                throw ;
            }
           
        }
    }
}
