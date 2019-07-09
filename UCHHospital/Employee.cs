using System;
using System.Collections.Generic;
using System.Text;

namespace UCHHospital
{
    public class Employee
    {
        public string Name { get; set; }
        public int Enumber { get; set; }
        public double Salary { get; set; }
        public bool PaidOrNot { get; set; }

        public Employee(string name, int eNumber, double salary)
        {
            Name = name;
            Enumber = eNumber;
            Salary = salary;
            PaidOrNot = false;
        }

        public virtual void PrintEmployees()
        {
            Console.WriteLine("--------");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Number: " + Enumber);
        }

        public virtual void PayEmployee()
        {
            if(this.PaidOrNot != true)
            {
                Console.WriteLine("-------");
                Console.WriteLine("You have paid this employee");
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Number: " + Enumber);
            }
            else
            {
                Console.WriteLine("-------");
                Console.WriteLine("You have already payed this employee");
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Number: " + Enumber);
            }
        }

        public virtual void DrawBlood(Patient currentPatient)
        {
            currentPatient.BloodLevel -= 1;
            Console.WriteLine("The doctor has drawn blood from the patient");
        }

        public virtual void CarePatient(Patient currentPatient)
        {
            currentPatient.HealthLevel += 1;
            Console.WriteLine("The doctor has care for the patient");
        }
    }
}
