using System;
namespace DesignPatterns.FactoryMethod
{
    public class ICTMinister : Minister
    {
        protected override IGovernmentAuthority CreateAuthority()
        {
            return new TechAuthority();
        }
    }
}
