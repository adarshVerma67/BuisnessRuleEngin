using BuisnessRuleEngineControllers.Model;
using System;
using Console = System.Diagnostics.Debug;

namespace BuisnessRuleEngine.Service.Classes
{
  public  abstract class PaymentTypesBaseClass
    {
        /// <summary>
        /// Fills Name and phone number
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="phoneNumber">phoneNumber</param>
        public abstract void FillMinDetail(string name, long phoneNumber);

        /// <summary>
        /// Performs Payment Type Specific Actions
        /// </summary>
        /// <param name="paymentDetails">paymentDetails</param>
        public abstract void PerformOperations(PaymentDetails paymentDetails);

        /// <summary>
        /// Generates Packing Slip
        /// </summary>
        /// <param name="paymentDetails">paymentDetails</param>
        /// <param name="department">department</param>
        public virtual void GeneratePackingSlip(PaymentDetails paymentDetails, string department = "Shipping")
        {
            Console.WriteLine("***********");
            Console.WriteLine("payment slip Generated for \n Name : {0} \n Amount : {1} \n PhoneNumber : {2} \n department: {3}",
                paymentDetails.Name, paymentDetails.Amount, paymentDetails.PhoneNumber, department);
            Console.WriteLine("***********");
        }

        /// <summary>
        /// Sends Email
        /// </summary>
        /// <param name="paymentDetails">paymentDetails</param>
        /// <param name="typeOfMembershipPayment">typeOfMembershipPayment</param>
        public virtual void SendEmail(PaymentDetails paymentDetails, string typeOfMembershipPayment)
        {//Generate payment slip 
            Console.WriteLine("***********");
            Console.WriteLine("Email Generated for \n Name : {0}\n Amount :{1}\n Email : {2}\n Type : {3}",
                paymentDetails.Name, paymentDetails.Amount, paymentDetails.Email, typeOfMembershipPayment);
            Console.WriteLine("***********");
        }

        /// <summary>
        /// Generates Commission
        /// </summary>
        /// <param name="paymentDetails">paymentDetails</param>
        public virtual void GenerateCommission(PaymentDetails paymentDetails)
        {//Generate payment slip 
            Console.WriteLine("***********");
            Console.WriteLine("Email Generated for \n Name : {0}\n Amount : {1}\n Email : {2}",
                paymentDetails.Name, paymentDetails.Amount, paymentDetails.Email);
            Console.WriteLine("***********");
        }

    }
}
