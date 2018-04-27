using System;
namespace DesignPatterns.Creational.FactoryMethod
{
    public class ICTMinister : Minister
    {
        protected override IGovernmentAuthority CreateAuthority()
        {
            return new TechAuthority();
        }
    }
}
