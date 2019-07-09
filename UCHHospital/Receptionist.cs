using System;
using System.Collections.Generic;
using System.Text;

namespace UCHHospital
{
    public class Receptionist : Employee
    {
        public bool IsOnThePhone { get; set; }


        public Receptionist(string name, int eNumber, bool isOnThePhone) : base(name, eNumber, 45000)
        {
            IsOnThePhone = isOnThePhone;

        }
        public override void PrintEmployees()
        {
            base.PrintEmployees();
            Console.WriteLine("Is on the phone: " + IsOnThePhone);
        }
        public override void PayEmployee()
        {
            base.PayEmployee();
            Console.WriteLine("Salary: " + base.Salary);
        }
    }
}




