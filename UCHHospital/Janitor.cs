using System;
using System.Collections.Generic;
using System.Text;

namespace UCHHospital
{
    class Janitor : Employee
    {
        public bool IsSweeping { get; set; }

        public Janitor(string name, int eNumber, bool isSweeping) : base(name, eNumber, 40000)
        {
            IsSweeping = isSweeping;
        }

        public override void PrintEmployees()
        {
            base.PrintEmployees()
            Console.WriteLine("Sweeping Status: " + IsSweeping);
        }

        public override void PayEmployee()
        {
            base.PayEmployee();
            Console.WriteLine("Salary: " + base.Salary);
        }
    }
}
