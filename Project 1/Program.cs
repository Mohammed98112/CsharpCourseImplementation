using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;

namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //Variables
            string patientName = "";
            string PatientNumber = "";
            double PatientRecord = 0;
            string PAtientBD = "";
            string PatientWeight = "";
            string PatientAge = "0";
            char PatiendCity = 'A';
            string PatientHeght = "0";
            bool ISpatientActive = false;


            
            //Main Menue.
            bool exit = false;
            while (exit == false)
            { 
            Console.WriteLine("===== PATIENT MENU =====");
            Console.WriteLine("1. Add Patient");
            Console.WriteLine("2. View Patient");
            Console.WriteLine("3. Update Patient");
            Console.WriteLine("4. Delete Patient");
            Console.WriteLine("5. Exit");

            int Option;
            Console.WriteLine("Enter Your Choice: ");
            int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {

                    //1. Add Patient
                    case 1:
                        if (ISpatientActive == true)
                        {
                            Console.WriteLine("Patient already exit");
                        }


                        else
                        {

                            Console.WriteLine("Enter Patient Name: ");
                            patientName = Console.ReadLine();
                            Console.WriteLine("Enter Patient Number: ");
                            PatientNumber = Console.ReadLine();
                            Console.WriteLine("Enter Patient BD: ");
                            PAtientBD = Console.ReadLine();

                        }
                        break;



                    //2. View Patient
                    case 2:
                        if (ISpatientActive == true)
                        {
                            Console.WriteLine("No information founded");
                        }
                        else
                        {
                            Console.WriteLine("Enter Patient Name: " + patientName);
                            Console.WriteLine("Enter Patient Number: " + PatientNumber);
                            Console.WriteLine("Enter Patient BD: " + PatientNumber);


                        }
                        break;


                    //3. Update Patient
                    case 3:
                        Console.WriteLine("Choose what you want to edit: ");
                        Console.WriteLine("1. Patient Name: ");
                        Console.WriteLine("2. Patient Number: ");
                        Console.WriteLine("3.Patient BD: ");

                        int choice = Convert.ToInt32(Console.ReadLine());

                        if (choice == 1)
                        {
                            Console.WriteLine("enter new Patient Name: ");
                            patientName = Console.ReadLine();
                            Console.WriteLine("patient name updated successfully");
                        }

                        else if (choice == 2)
                        {
                            Console.WriteLine("enter new Patient number: ");
                            PatientNumber = Console.ReadLine();
                            Console.WriteLine("patient number updated successfully");
                        }

                        else if (choice == 3)
                        {
                            Console.WriteLine("enter new Patient BD");
                            PAtientBD = Console.ReadLine();
                            Console.WriteLine("patient BD  updated successfully");
                        }
                        else
                            Console.WriteLine("ivalid option");
                        break;

                    //4. Delete Patient
                    case 4:
                        if (ISpatientActive == false)
                        {
                            Console.WriteLine("There is no information to delete");
                        }

                        else
                        Console.WriteLine("Are you sure you want to delete patient in formation?: ");
                        Console.WriteLine("1. Yes: ");
                        Console.WriteLine("2.No: ");

                        int delete = Convert.ToInt32(Console.ReadLine());

                        if (delete == 1)
                        {

                            patientName = "";
                            PatientNumber = "";
                            PAtientBD = "";

                            ISpatientActive = false;

                            Console.WriteLine("patient deleted successfully");
                        }
                        else
                        {
                            Console.WriteLine("the operation cancelled");

                        }
                        
                        break;

                    //5. Exit

                    case 5:
                        exit = true;
                         break;


                    default:
                        Console.WriteLine("invalid option");
                        break;
                }

                Console.WriteLine("press any key to continue...");
                Console.ReadKey();
                Console.Clear();

            }
        }

















    }
}

