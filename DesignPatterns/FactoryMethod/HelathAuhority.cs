using System;
namespace DesignPatterns.FactoryMethod
{
    public class HelathAuhority : IGovernmentAuthority
    {
        public void EnfoceLaw()
        {
            Console.WriteLine("stay healthy!");
        }
    }
}
