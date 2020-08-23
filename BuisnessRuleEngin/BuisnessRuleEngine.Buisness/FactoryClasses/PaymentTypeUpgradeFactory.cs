using BuisnessRuleEngine.Buisness.FactoryClasses;
using BuisnessRuleEngine.Buisness.PaymentTypeClasses;
using BuisnessRuleEngine.Service.Classes;

namespace BuisnessRuleEngine.Buisness.FactoryClasses
{
    public class PaymentTypeUpgradeFactory : PaymentTypeFactory
    {
        public PaymentTypeUpgradeFactory() { }
        public override PaymentTypesBaseClass GenerateTypeClass()
        {
            return new PaymentTypeLearningToSki();
        }
    }
}