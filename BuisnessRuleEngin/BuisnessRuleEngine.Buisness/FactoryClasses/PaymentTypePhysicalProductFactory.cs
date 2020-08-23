using BuisnessRuleEngine.Buisness.FactoryClasses;
using BuisnessRuleEngine.Service.Classes;

namespace BuisnessRuleEngine.Buisness
{
    public class PaymentTypePhysicalProductFactory : PaymentTypeFactory
   
    {
        public PaymentTypePhysicalProductFactory() { }
        public override PaymentTypesBaseClass GenerateTypeClass()
        {
            return new PaymentTypePhysicalProduct();
        }
    }
}