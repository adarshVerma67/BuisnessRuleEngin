using BuisnessRuleEngin.DB;
using BuisnessRuleEngine.Buisness.FactoryClasses;
using BuisnessRuleEngine.Service.Classes;
using BuisnessRuleEngineControllers.Model;
using System;
using System.Collections.Generic;

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
                PaymentTypeFactory paymentFactory = null;
                bool insertStatus = buisnessRuleEngineDB.SubmitPayment(paymentDetails);
                if (insertStatus)
                {
                    switch (paymentDetails.TypeofPayment)
                    {
                        case PaymentTypeEnum.PhysicalProduct:
                            paymentFactory = new PaymentTypePhysicalProductFactory();
                            break;
                        case PaymentTypeEnum.Book:
                            paymentFactory = new PaymentTypeBookFactory();
                            break;
                        case PaymentTypeEnum.MemberShip:
                            paymentFactory = new PaymentTypeMemberShipFactory();
                            break;
                        case PaymentTypeEnum.Upgrade:
                            paymentFactory = new PaymentTypeUpgradeFactory();
                            break;
                        case PaymentTypeEnum.LearningToSki:
                            paymentFactory = new PaymentTypeLearningToSkiFactory();
                            break;
                        default:
                            return false;
                    }
                }

                PaymentTypesBaseClass paymentTypesBaseClass = paymentFactory.GenerateTypeClass();
                paymentTypesBaseClass.FillMinDetail("adarsh", "8888888888");
                paymentTypesBaseClass.PerformOperations(paymentDetails);

                return insertStatus;

            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
