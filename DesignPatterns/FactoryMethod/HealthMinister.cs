using System;
namespace DesignPatterns.FactoryMethod
{
    public class HealthMinister : Minister
    {
        protected override IGovernmentAuthority CreateAuthority()
        {
            return new HelathAuhority();
        }
    }
}
