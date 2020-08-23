using BuisnessRuleEngine.Buisness.FactoryClasses;
using BuisnessRuleEngine.Service.Classes;

namespace BuisnessRuleEngine.Buisness.FactoryClasses
{
    public class PaymentTypeMemberShipFactory : PaymentTypeFactory
    {
        public PaymentTypeMemberShipFactory() { }
        public override PaymentTypesBaseClass GenerateTypeClass()
        {
            return new PaymentTypeMemberShip();
        }
    }
}