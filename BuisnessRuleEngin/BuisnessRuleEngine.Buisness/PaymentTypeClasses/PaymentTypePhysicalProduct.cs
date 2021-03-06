﻿using BuisnessRuleEngineControllers.Model;

namespace BuisnessRuleEngine.Service.Classes
{
    public class PaymentTypePhysicalProduct : PaymentTypesBaseClass
    {
        private string name;
        private long phoneNumber;
        private readonly string department;

        public PaymentTypePhysicalProduct()
        {
            department = "Shipping";
        }

        /// <summary>
        /// Fills Name and phone number
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="phoneNumber">phoneNumber</param>
        public override void FillMinDetail(string _name, long _phoneNumber)
        {
            name = _name;
            phoneNumber = _phoneNumber;
        }

        /// <summary>
        /// Performs Payment Type Specific Actions
        /// </summary>
        /// <param name="paymentDetails">paymentDetails</param>
        public override void PerformOperations(PaymentDetails paymentDetails)
        {
            base.GeneratePackingSlip(paymentDetails, department);
            GenerateCommission(paymentDetails);
        }
    }
}