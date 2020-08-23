using BuisnessRuleEngineControllers.Model;
using System;

namespace BuisnessRuleEngine.Service.Classes
{
  public  abstract class PaymentTypesBaseClass
    {

        public abstract void FillMinDetail(string name, string phoneNumber);

        public abstract void PerformOperations(PaymentDetails paymentDetails);

        public virtual void GeneratePackingSlip(PaymentDetails paymentDetails, string department = "Shipping")
        {//Generate payment slip 
            Console.WriteLine("payment slip Generated for \\n Name :{0}\\n Amount :{1}\\n PhoneNumber :{2} \\n department:{3}",
                paymentDetails.Name, paymentDetails.Amount, paymentDetails.PhoneNumber, department);
        }

    }
}
