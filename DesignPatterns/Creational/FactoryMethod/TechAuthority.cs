using System;
namespace DesignPatterns.Creational.FactoryMethod
{
    public class TechAuthority : IGovernmentAuthority
    {
        public void EnfoceLaw()
        {
            Console.WriteLine("you must use domestic messaging apps!");
        }
    }
}
