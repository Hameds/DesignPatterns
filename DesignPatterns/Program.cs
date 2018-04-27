using System;
using DesignPatterns.Creational.FactoryMethod;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to design patterns sample. watch design pattern videos (in Persian): http://youtube.com/softwaretalks");

            //Call factory method example
            FactoryMethodExample();


            Console.WriteLine("press any key to exit ...");
            Console.ReadKey();
        }


        #region Call Creational Design Patterns
        public static void FactoryMethodExample()
        {
            Console.WriteLine("Factory Method example");
            var azariJahromi = new ICTMinister();
            azariJahromi.Manage();

            var ghazizadehHashemi = new HealthMinister();
            ghazizadehHashemi.Manage();
        }
        #endregion
    }
}
