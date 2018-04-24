using System;
namespace DesignPatterns.FactoryMethod
{
    public class TechAuthority : IGovernmentAuthority
    {
        public void EnfoceLaw()
        {
            Console.WriteLine("you must use domestic messaging apps!");
        }
    }
}
