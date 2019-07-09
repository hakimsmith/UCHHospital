using System;
using System.Collections.Generic;
using System.Text;

namespace UCHHospital
{
    public class Doctor : Employee
    {
        public string SpecialtyArea { get; set; }

        public Doctor(string name, int eNumber, string specialtyArea) : base(name, eNumber, 90000)
        {
            SpecialtyArea = specialtyArea;
        }

        public override void PrintEmployees()
        {
            base.PrintEmployees();
            Console.WriteLine("Specialty: " + SpecialtyArea);
        }

        public override void PayEmployee()
        {
            base.PayEmployee();
            Console.WriteLine("Salary: " + base.Salary);
        }

        public override void DrawBlood(Patient currentPatient)
        {
            currentPatient.BloodLevel -= 2;
            Console.WriteLine("The doctor has drawn blood from Fragile Bob");
            Console.WriteLine($"The patient's health level is at { currentPatient.BloodLevel}");
            Console.ReadLine();
        }

        public override void CarePatient(Patient currentPatient)
        {
            currentPatient.HealthLevel += 1;
            Console.WriteLine("The doctor has cared for Fragile Bob");
            Console.WriteLine($"The patient's health level is at { currentPatient.HealthLevel}");
        }

    }
}
