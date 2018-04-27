using System;
namespace DesignPatterns.Creational.FactoryMethod
{
    public class HealthMinister : Minister
    {
        protected override IGovernmentAuthority CreateAuthority()
        {
            return new HelathAuhority();
        }
    }
}
