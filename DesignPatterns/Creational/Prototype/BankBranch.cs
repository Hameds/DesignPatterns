using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Prototype
{
    public class BankBranch
    {
        public string Code { get; set; }
        public string ManagerName { get; set; }

        public BankBranch(string code, string managerName)
        {
            Code = code;
            ManagerName = managerName;
        }

        public BankBranch Clone()
        {
            return MemberwiseClone() as BankBranch;
        }
    }
}
