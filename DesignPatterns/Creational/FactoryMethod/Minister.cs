using System;
namespace DesignPatterns.Creational.FactoryMethod
{
    public abstract class Minister
    {
        abstract protected IGovernmentAuthority CreateAuthority();


        public void Manage()
        {
            var authorityGuy = this.CreateAuthority();
            authorityGuy.EnfoceLaw();
        }
    }
}
