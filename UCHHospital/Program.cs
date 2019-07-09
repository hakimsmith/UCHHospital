using System;
using System.Collections.Generic;

namespace UCHHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listOfEmployees = new List<Employee>();
            Employee doctorJohn = new Doctor("Doctoe John", 111, "Heart Doctor");
            Employee nurseBetty = new Nurse("Nurse Betty", 222, 15);
            Employee doctorBrown = new Doctor("Doc Brown", 333, "Psychologist");
            Employee nurseDebbie = new Nurse("Nurse Debbie", 444, 25);
            Employee janitorMoe = new Janitor("Moe the Janitor", 555, true);
            Employee receptionistDoris = new Receptionist("Doris the receptionist", 777, true);
            Patient fragileBob = new Patient("Fragile Bob");

            Menu menu = new Menu();

            listOfEmployees.Add(doctorJohn);
            listOfEmployees.Add(nurseBetty);
            listOfEmployees.Add(doctorBrown);
            listOfEmployees.Add(nurseDebbie);
            listOfEmployees.Add(janitorMoe);
            listOfEmployees.Add(receptionistDoris);
            string userInput = "";

            while (userInput != "7")
            {
                Console.Clear();
                menu.ShowMainMenu();
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        {
                            Console.Clear();

                            for (int i = 0; i < listOfEmployees.Count; i++)
                            {
                                Console.Write(i + " ");
                                listOfEmployees[i].PrintEmployees();
                            }
                            Console.ReadKey();
                        }
                        break;

                    case "2":
                        {
                            Console.Clear();
                            doctorJohn.PayEmployee();
                            nurseBetty.PayEmployee();
                            nurseDebbie.PayEmployee();
                            doctorBrown.PayEmployee();
                            janitorMoe.PayEmployee();
                            receptionistDoris.PayEmployee();
                            Console.ReadKey();
                        }
                        break;

                    case "3":
                        {
                            Console.Clear();
                            for (int i = 0; i < listOfEmployees.Count; i++)
                            {
                                Console.Write(i + " ");
                                listOfEmployees[i].PrintEmployees();
                            }

                            Console.WriteLine("Input number of employee you want to select.");
                            int choiceInput = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("you've slected: ");
                            listOfEmployees[choiceInput].PrintEmployees();
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                        }
                        break;

                    case "4":
                        {
                            Console.WriteLine("Choose employee to draw blood?");
                            Console.WriteLine("1. Doctor");
                            Console.WriteLine("2. Nurse");
                            string drawChoice = (Console.ReadLine());
                            switch (drawChoice)
                            {
                                case "1":
                                    doctorJohn.DrawBlood(fragileBob);
                                    break;
                                case "2":
                                    nurseBetty.DrawBlood(fragileBob);
                                    break;
                                default:
                                    return;
                            }
                        }
                        break;

                    case "5":
                        {
                            Console.WriteLine("Who would you like to care for the patient?");
                            Console.WriteLine("1. Doctor");
                            Console.WriteLine("2. Nurse");
                            string careChoice = (Console.ReadLine());
                            switch (careChoice)
                            {
                                case "1":
                                    doctorBrown.CarePatient(fragileBob);
                                    break;
                                case "2":
                                    nurseDebbie.CarePatient(fragileBob);
                                    break;
                                default:
                                    return;
                            }
                        }
                        break;

                    case "6":
                        {
                            Console.Clear();
                            Console.WriteLine("Adios...means bye bye!");
                            Console.ReadKey();
                        }
                        break;
                }
            }
            Console.WriteLine("Finish");
            Console.ReadKey();
        }
    }
}
