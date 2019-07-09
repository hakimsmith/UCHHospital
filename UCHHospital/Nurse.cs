using System;
using System.Collections.Generic;
using System.Text;

namespace UCHHospital
{
    class Nurse : Employee
    {
        public int NumberOfPatients { get; set; }

        public Nurse(string name, int eNumber, int numberOfPatients) : base(name, eNumber, 50000)
        {
            NumberOfPatients = numberOfPatients;
        }

        public override void PrintEmployees()
        {
            base.PrintEmployees();
            Console.WriteLine("Number of Patients: " + NumberOfPatients);
        }

        public override void PayEmployee()
        {
            base.PayEmployee();
            Console.WriteLine("Salary: " + base.Salary);
        }

        public override void DrawBlood(Patient currentPatient)
        {
            currentPatient.BloodLevel -= 2;
            Console.WriteLine("The Nurse has drawn blood from Fragile Bob");
            Console.WriteLine($"The patient's Blood Level is at { currentPatient.BloodLevel}");
            Console.ReadLine();
        }

        public override void CarePatient(Patient currentPatient)
        {
            currentPatient.HealthLevel += 1;
            Console.WriteLine("The Nurse has cared for Fragile Bob");
            Console.WriteLine($"The patient's Health Level is at { currentPatient.HealthLevel}");
            Console.ReadLine();

        }
    }
}
