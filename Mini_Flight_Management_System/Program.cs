using System.Xml.Linq;

namespace Mini_Flight_Management_System
{
    internal class Program
    {
        //varibales
        static List<string> passengerNames = new List<string>()
{
    "Fahad",
    "Mohammed",
    "Ahmed",
    "Shaheen",
    "Aihem"

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
            Console.WriteLine("=== Register New Passenger ===");

            // Req 1) Prompt the clerk to enter the new passenger's full name.
            Console.WriteLine("enter your Full Name: ");
            string Name = Console.ReadLine();


            // Req 2) Validate that the name is not empty 

            if (Name == "") // Check if the entered name is empty

            {
                Console.WriteLine("Error: The name cannot be empty -_-");
                return;
            }

            // Req 2) Validate that the name does not already exist 

            if (passengerNames.Contains(Name) == true) // Check if the passenger name already exists in the passengerNames list
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
            Console.WriteLine("=== View All Passengers ===");


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
                string status = "Active";  //defualt status for each passenger

                if (cancelledTickets.Contains(ticketNumbers[i]))
                {

                    status = "CANCELLED"; //if ticket number inside cancelled tickets = cancel,,, otherwise Active


                }



                Console.WriteLine((i + 1) + " | " + passengerNames[i] + " | " + ticketNumbers[i] + " | " + status); // Display passenger details in a formatted row
                                                                                                                    // including serial number, name, ticket ID, and status




            }


            // Req 5: Total passenger
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Total Passengers: " + passengerNames.Count);
        }

        //case 3) Book a Flight Ticket
        public static void BookFlightTicket()
        {
            Console.WriteLine("=== Book a Flight Ticket ===");

            // Req 1: Prompt for a ticket ID

            Console.WriteLine("enter Ticket ID: ");
            string TicketID = Console.ReadLine();

            // Req 1: Validate it exists in ticketNumbers
            if (ticketNumbers.Contains(TicketID) == true) // Check if the TicketID does NOT exist in the ticketNumbers list

            {

                Console.WriteLine("the tecket ID is Invalid");
                return;
            }

            // Req 1: Validate it is not in cancelledTickets

            if (cancelledTickets.Contains(TicketID) == true) // Check if the TicketID exists in the cancelledTickets list

            {

                Console.WriteLine("the tecket  is cancelled");
                return;
            }

            // Req 2: Check if the ticket is already in bookingRecord

            if (bookingRecord.ContainsKey(TicketID)) // Check if the TicketID already exists in the bookingRecord dictionary

            {

                Console.WriteLine("the ticket already has a booking ");
                return;


            }

            // Req 3 :  Display all available flight numbers 

            for (int i = 0; i < flightNumbers.Length; i++) // Loop through all available flight numbers
                                                           // and display them with index numbers starting from 1
            {

                Console.WriteLine($"{i + 1}. flightNumber: {flightNumbers[i]}");

            }

            // Req 4 :  Prompt the user to select a flight by entering

            Console.WriteLine("select flight number: ");
            int flight = Convert.ToInt32(Console.ReadLine());


            if (flight < 0 || flight >= flightNumbers.Length) //// Check if the selected flight index is invalid (less than 0 or greater than available flights)

            {

                Console.WriteLine("it is out of range");

            }
            else
            {

                //req 5: Display all available dates

                Console.WriteLine($"Availables dates: ");
                for (int i = 0; i < availableDates.Count; i++)  // Loop through the availableDates list and print each date with its index
                {

                    Console.WriteLine(i + 1 + " " + availableDates[i]);

                }



                //req 5: . Prompt the user to select a date by index. Validate input.

                Console.Write("Select date index: ");
                int date = Convert.ToInt32(Console.ReadLine());

                if (date > 0 || date <= availableDates.Count)  // Validate that the entered index is within the valid range of availableDates list
                {
                    //req 6 : Display all available dates

                    string booking = flightNumbers[flight] + "|" + availableDates[date]; //Create booking string in format "FlightNumber|Date" as a value
                                                                                         //and store it in the bookingRecord dictionary using TicketID as the key

                    bookingRecord.Add(TicketID, booking);

                    //req 7 :  Display a booking confirmation
                    int passenger = ticketNumbers.IndexOf(TicketID); //// Find the passenger index based on the TicketID in the ticketNumbers list
                    Console.WriteLine("Booking Confirmed"); // Display booking confirmation details
                    Console.Write("");
                    Console.WriteLine($"Ticket ID: {TicketID}"); // Display ticket ID
                    Console.Write("");
                    Console.WriteLine($"Passenger Name: {passengerNames[passenger]}"); // Display passenger name using the found index
                    Console.Write("");
                    Console.WriteLine("Flight: " + flightNumbers[flight - 1]); // Display selected flight using flight index
                    Console.Write("");
                    Console.WriteLine("Date: " + availableDates[date - 1]); // Display selected date using date index



                }
                else
                {

                    Console.Write("wrong option ");


                }
            }






        }

        //case 4) View Booking Details 
        public static void ViewBookingDetails()
        {

            Console.WriteLine("=== View Booking Details ===");

            // Req 1: Prompt for a ticket ID

            Console.WriteLine("enter Ticket ID: ");
            string TicketID = Console.ReadLine();

            if (ticketNumbers.Contains(TicketID) == false)
            {

                Console.WriteLine("the ticket not found");
                return;
            }

            // Req 2:  Retrieve the passenger name from passengerNames

            int passenger = ticketNumbers.IndexOf( TicketID); // Find the passenger's name by locating the TicketID in
                                                             // ticketNumbers and using the same index in passengerNames

            string PassengerName = passengerNames[passenger];

            // Req 3:  Check if the ticket is in cancelledTickets

            if (cancelledTickets.Contains(TicketID) == true) // Check if the TicketID exists in the cancelledTickets list

            {

                Console.WriteLine("the tecket  is cancelled");

            }

            // req 4 : retrieve the booking value

            if (!bookingRecord.ContainsValue(TicketID))
            { 

                Console.WriteLine("No booking found for this ticket");

            }

            // req 5 : retrieve the booking value



        }


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
                        BookFlightTicket();
                        break;



                    //case 4) View Booking Details
                    case 4:
                        ViewBookingDetails();
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
