﻿using BuisnessRuleEngine.Service.Classes;
using BuisnessRuleEngineControllers.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessRuleEngine.Buisness.PaymentTypeClasses
{
  public  class PaymentTypeLearningToSki : PaymentTypesBaseClass
    {
        private string name;

        private string phoneNumber;
        public  PaymentTypeLearningToSki() { }

        public override void FillMinDetail(string _name, string _phoneNumber)
        {
            name = _name;
            phoneNumber = _phoneNumber;
        }

        public override void PerformOperations(PaymentDetails paymentDetails)
        {
            AddFirstAidVideo(paymentDetails.Email);
            //Add free first Aid Video
        }

        /// <summary>
        /// Add free first Aid Video
        /// </summary>
        /// <param name="email"></param>
        private void AddFirstAidVideo(string email)
        {
            
        }
    }
}
