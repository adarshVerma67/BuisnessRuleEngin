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
                paymentFactory = GenerateType(paymentDetails.TypeofPayment);
                if (paymentFactory == null)
                {
                    return false;
                }

                bool insertStatus = buisnessRuleEngineDB.SubmitPayment(paymentDetails);
                if (insertStatus)
                {
                    PaymentTypesBaseClass paymentTypesBaseClass = paymentFactory?.GenerateTypeClass();
                    paymentTypesBaseClass.FillMinDetail(paymentDetails.Name, paymentDetails.PhoneNumber);
                    paymentTypesBaseClass.PerformOperations(paymentDetails);
                }

                return insertStatus;

            }
            catch (Exception)
            {
                throw;
            }

        }

        private PaymentTypeFactory GenerateType(PaymentTypeEnum typeofPayment)
        {
            PaymentTypeFactory paymentFactory;
            switch (typeofPayment)
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
                    return null;
            }

            return paymentFactory;
        }
    }
}
