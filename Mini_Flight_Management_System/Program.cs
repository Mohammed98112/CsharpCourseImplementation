using System.Xml.Linq;

namespace Mini_Flight_Management_System
{
    internal class Program
    {
        //case 1 varibales
        static List<string> passengerNames = new List<string>();
        static List<string> ticketNumbers = new List<string>();
        //Main menu
        public static int mainmenue()
        {

            Console.WriteLine("=================================");
            Console.WriteLine(" SKY WINGS FLIGHT MANAGEMENT SYSTEM");
            Console.WriteLine("=================================");

            Console.WriteLine("1. Register New Passenger");
            Console.WriteLine("2. View All Passengers");
            Console.WriteLine("3. Book a Flight Ticket");
            Console.WriteLine("4. View Booking Details");
            Console.WriteLine("5. Update a Booking");
            Console.WriteLine("6. Cancel a Ticket");
            Console.WriteLine("7. Passenger Check-In");
            Console.WriteLine("8. Board Passengers (Boarding Stack");
            Console.WriteLine("9. Generate Flight Manifest");
            Console.WriteLine("10. Manage Waitlist & Seat Assignment");
            Console.WriteLine("0. exit");
            Console.WriteLine("=================================");

            Console.WriteLine("enter your choice: ");

            return Convert.ToInt32(Console.ReadLine());


        }
        // ALL Functions

        //case 1) Register New Passenger

        public static void RegisterNewPassenger()
        {

            // Req 1) Prompt the clerk to enter the new passenger's full name.
            Console.WriteLine("enter your Full Name: ");
            string Name = Console.ReadLine();
            

            // Req 2) Validate that the name is not empty 
            
            if (Name == "")
            {
                Console.WriteLine("Error: The name cannot be empty -_-");
                return;
            }

            // Req 2) Validate that the name does not already exist 
           
                if (passengerNames.Contains(Name) == true)
                {
                    Console.WriteLine("The Name is already exists");
                return;
                }

                else
                {

                Console.WriteLine("The Name was successfully added.....");

                }

            Console.WriteLine("");

            // Req 3) Auto-generate the ticket ID
            string TicketID = " TKT-" + (passengerNames.Count + 1).ToString("D3");


            // Req 4: Add passenger name and ticket ID to lists

            passengerNames.Add(Name);
            ticketNumbers.Add(TicketID);


            // Req 5: Add passenger name and ticket ID to lists
            Console.WriteLine("Passenger registered successfully!");
            Console.WriteLine("Passenger Name: " + Name);
            Console.WriteLine("Ticket ID: " + TicketID);
        }



        //case 2) View All Passengers


        //case 3) Book a Flight Ticket


        //case 4) View Booking Details


        //case 5) Update a Booking


        //case 6) Cancel a Ticket


        //case 7) Passenger Check-In


        //case 8) Board Passengers Boarding Stack


        //case 9) Generate Flight Manifest


        //case 10) Manage Waitlist & Seat Assignment

        static void Main(string[] args)
        {


            bool exit = false;
            while (exit == false)
            {
                switch (mainmenue())
                {



                    //case 1) Register New Passenger

                    case 1:
                        RegisterNewPassenger();
                        break;


                    //case 2) View All Passengers
                    case 2:
                        break;


                    //case 3) Book a Flight Ticket
                    case 3:

                        break;



                    //case 4) View Booking Details
                    case 4:

                        break;


                    //case 5) Update a Booking
                    case 5:

                        break;



                    //case 6) Cancel a Ticket
                    case 6:

                        break;


                    //case 7) Passenger Check-In
                    case 7:
                        break;


                    //case 8) Board Passengers Boarding Stack
                    case 8:
                        break;

                    //case 9) Generate Flight Manifest
                    case 9:
                        break;


                    //case 10) Manage Waitlist & Seat Assignment
                    case 10:
                        break;

                    //case 0) Exit
                    case 11:
                        exit = true;
                        break;


                    //wrong option
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
