using BuisnessRuleEngine.Buisness.FactoryClasses;
using BuisnessRuleEngine.Buisness.PaymentTypeClasses;
using BuisnessRuleEngine.Service.Classes;

namespace BuisnessRuleEngine.Buisness.FactoryClasses
{
    public class PaymentTypeLearningToSkiFactory : PaymentTypeFactory
    {
        public PaymentTypeLearningToSkiFactory() { }
        public override PaymentTypesBaseClass GenerateTypeClass()
        {
            return new PaymentTypeLearningToSki();
        }
    }
}