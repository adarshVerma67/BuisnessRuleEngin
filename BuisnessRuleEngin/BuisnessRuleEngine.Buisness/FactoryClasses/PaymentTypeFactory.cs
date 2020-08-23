using BuisnessRuleEngine.Service.Classes;

namespace BuisnessRuleEngine.Buisness.FactoryClasses
{
  public  abstract class PaymentTypeFactory
    {
        public abstract PaymentTypesBaseClass GenerateTypeClass();
    }
}
