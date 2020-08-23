using BuisnessRuleEngine.Service.Classes;

namespace BuisnessRuleEngine.Buisness.FactoryClasses
{
    public class PaymentTypeBookFactory : PaymentTypeFactory
    {
        public PaymentTypeBookFactory() { }
        public override PaymentTypesBaseClass GenerateTypeClass()
        {
            return new PaymentTypeBook();
        }
    }
}
