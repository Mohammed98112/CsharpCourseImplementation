using System.Xml.Linq;

namespace Mini_Flight_Management_System
{
    internal class Program
    {
        //varibales
        static List<string> passengerNames = new List<string>()
{
    "Mohammed",
    "Ahmed",
    "Shaheen",
    "Aihem",
    "Fahad"
};
        static List<string> ticketNumbers = new List<string>()
{
    "TKT-001",
    "TKT-002",
    "TKT-003",
    "TKT-004",
    "TKT-005"
};
        static string[] flightNumbers = new string[]
            {
    "200",
    "201",
    "202",
    "203",
    "204",
    "205"
};
        static List<string> availableDates = new List<string>()
            {
    "10-Jun-2026",
    "12-Jun-2026",
    "15-Jun-2026",
    "18-Jun-2026"
};
        static Dictionary<string, string> bookingRecord = new Dictionary<string, string>();
        static Queue<string> checkedInQueue = new Queue<string>();
        static Stack<string> boardingStack = new Stack<string>();
        static List<string> cancelledTickets = new List<string>();
        static Dictionary<string, string> passengerSeatMap = new Dictionary<string, string>();
        static Queue<string> waitlistQueue = new Queue<string>();
        string status = "Active";
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


            // Req 5: Display 
            Console.WriteLine("Passenger registered successfully!");
            Console.WriteLine("Passenger Name: " + Name);
            Console.WriteLine("Ticket ID: " + TicketID);
        }

        //case 2) View All Passengers
        public static void ViewAllPassengers()
        {
            //req 1) Check if passengerNames is empty

            if (passengerNames.Count == 0)
            {
                Console.WriteLine("No passengers registered yet.");

                return;
            }

            //req 2) Display a formatted table header:

            Console.WriteLine("No. | Passenger Name | Ticket ID | Status");
            Console.WriteLine("========================================");


            //req 3 + 4) loop + check
            for (int i = 0; i < passengerNames.Count; i++)
            {
                string status = "Active";

                if (cancelledTickets.Contains(ticketNumbers[i]))
                {

                    status = "CANCELLED";


                }



                Console.WriteLine((i + 1) + " | " + passengerNames[i] + " | " + ticketNumbers[i] + " | " + status);



            }


            // Req 5: Total passenger
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Total Passengers: " + passengerNames.Count);
        }



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
                        ViewAllPassengers();
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
