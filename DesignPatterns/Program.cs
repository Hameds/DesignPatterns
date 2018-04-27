using System;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Prototype;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to design patterns sample. watch design pattern videos (in Persian): http://youtube.com/softwaretalks");

            //Call Creational Design Patterns examples
            Console.WriteLine("calling creational design patterns examples");
            FactoryMethodExample();
            PrototypeExample();


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

        public static void PrototypeExample()
        {
            Console.WriteLine("Prototype example");

            var branch1 = new BankBranch("1", "Behnam");
            Console.WriteLine(branch1.Code);
            Console.WriteLine(branch1.ManagerName);

            var branch2 = branch1.Clone();
            branch2.Code = "2";
            branch2.ManagerName = "Maryam";
            Console.WriteLine(branch2.Code);
            Console.WriteLine(branch2.ManagerName);
            Console.WriteLine(branch1.Code);
            Console.WriteLine(branch1.ManagerName);
        }

        #endregion
    }
}
