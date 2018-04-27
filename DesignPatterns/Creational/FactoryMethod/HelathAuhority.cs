using System;
namespace DesignPatterns.Creational.FactoryMethod
{
    public class HelathAuhority : IGovernmentAuthority
    {
        public void EnfoceLaw()
        {
            Console.WriteLine("stay healthy!");
        }
    }
}
