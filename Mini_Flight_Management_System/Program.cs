using System.Buffers.Text;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;
using System.Text.RegularExpressions;
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
            if (ticketNumbers.Contains(TicketID) == false) // Check if the TicketID does NOT exist in the ticketNumbers list

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
                    Console.WriteLine("Booking Confirmed!!"); // Display booking confirmation details
                    Console.WriteLine("");
                    Console.WriteLine($"Ticket ID: {TicketID}"); // Display ticket ID
                    Console.WriteLine($"Passenger Name: {passengerNames[passenger]}"); // Display passenger name using the found index
                    Console.WriteLine("Flight: " + flightNumbers[flight - 1]); // Display selected flight using flight index
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
                return;
            }

            // req 4 : retrieve the booking value

            if (!bookingRecord.ContainsKey(TicketID)) // Check if the TicketID exists in the bookingRecord dictionary

            {

                Console.WriteLine("No booking found for this ticket");
                return;
            }

            // req 5 : retrieve the booking value
            //string = single value
            //string + [] + split = multiple values

            string[] details = bookingRecord[TicketID].Split('|'); // Retrieve booking details from dictionary and split into flight number and date


            Console.WriteLine("=== Booking Summary ===");
            Console.WriteLine("Passenger: " + PassengerName);
            Console.WriteLine("Ticket ID: " + TicketID);
            Console.WriteLine("Flight No: " + details[0]);
            Console.WriteLine("Date: " + details[1]);


        }


        //case 5) Update a Booking
        public static void UpdateBooking()
        {
            // req 1:  Prompt for ticket ID. Validate it exists, is not cancelled, and has an existing booking in bookingRecord.
            Console.WriteLine("=== Update Booking ===");

            Console.WriteLine("");

            Console.WriteLine("enter ticket ID: ");
            string TicketID = Console.ReadLine();

            if (cancelledTickets.Contains(TicketID) == true) // Check if the TicketID exists in the cancelledTickets list

            {

                Console.WriteLine("the tecket  is cancelled");
                return;
            }

            if (bookingRecord.ContainsKey(TicketID) == false) // Check if the TicketID exists in the bookingRecord dictionary

            {

                Console.WriteLine("No booking found for this ticket");
                return;
            }

            //req 2:  Display the current booking details (flight and date) extracted from the dictionary value.
            string[] details = bookingRecord[TicketID].Split('|'); // Retrieve booking details from dictionary and split into flight number and date

            Console.WriteLine("");
            int passenger = ticketNumbers.IndexOf(TicketID); 
            string PassengerName = passengerNames[passenger];
            Console.WriteLine("=== Booking Details ===");
            Console.WriteLine("Passenger: " + PassengerName);
            Console.WriteLine("Ticket ID: " + TicketID);
            Console.WriteLine("Flight No: " + details[0]); // Display flight number (first part of split result)
            Console.WriteLine("Date: " + details[1]); // Display date (second part of split result)

            Console.WriteLine("");


            //req 3:  Present a sub-menu: (1) Change flight only (2) Change date only (3) Change both (0) Cancel update.
            Console.WriteLine("What do you want to update?");
            Console.WriteLine("1. Change flight only");
            Console.WriteLine("2. Change date only");
            Console.WriteLine("3. Change both");
            Console.WriteLine("0. Cancel update");

            Console.WriteLine("");


            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            string newFlight = details[0]; 

                                           // Store current flight and date as default values before updating

            string newDate = details[1];

            //req 4:  Based on selection, display available flights or dates and prompt for a new choice.Validate all inputs.
            switch (choice)
            {
                case 1:

                    
                        Console.WriteLine("Available Flights: ");
                    for (int i = 0; i < flightNumbers.Length; i++)
                    {
                        Console.WriteLine(i + 1 + ". " + flightNumbers[i]);
                    }

                    Console.WriteLine("");

                    Console.WriteLine("enter your new flight number: ");
                        newFlight = Console.ReadLine();
                        Console.WriteLine($"The new flight number is : {newFlight}");

                     break;




                case 2:

                    
                        Console.WriteLine("Available Dates: ");
                    for (int i = 0; i < availableDates.Count; i++)
                    {
                        Console.WriteLine(i + 1 + " " + availableDates[i]);
                    }

                    Console.WriteLine("");

                    Console.WriteLine("enter your new date number: ");
                        newDate = Console.ReadLine();
                        Console.WriteLine($"The new date  is : {newDate}");
                    break;


                case 3:
                    
                        Console.WriteLine("Available Flights: ");
                    for (int i = 0; i < flightNumbers.Length; i++)
                    {
                        Console.WriteLine(i + 1 + " " + flightNumbers[i]);
                    }

                    Console.WriteLine("");

                    Console.Write("Enter new flight number: ");
                        newFlight = Console.ReadLine();

                        Console.WriteLine("Available Dates: ");
                    for (int i = 0; i < availableDates.Count; i++)
                    {
                        Console.WriteLine(i + 1 + ". " + availableDates[i]);
                    }

                    Console.WriteLine("");

                    Console.Write("Enter new date: ");
                        newDate = Console.ReadLine();
                    break;

                case 0:
                        Console.WriteLine("Update cancelled");
                    break;

                default:
                    Console.WriteLine("invalid option");
                    break;
            }

            //req 5: Reconstruct the booking value string with the updated values and overwrite the existing dictionary entry.
            string oldBooking = bookingRecord[TicketID]; // Store the current (old) booking details before updating
            bookingRecord[TicketID] = newFlight + "|" + newDate; // Update the dictionary with the new flight and date values


            //req 6: Display a confirmation showing the old booking details and the new updated details side by side.
            Console.WriteLine("=== Booking Updated Successfully ===");
            Console.WriteLine("Old Booking: " + oldBooking);
            Console.WriteLine("New Booking: " + bookingRecord[TicketID]);



        }




        //case 6) Cancel a Ticket
        public static void CancelTicket()
        {


            //req: 1 Prompt for ticket ID. Validate it exists in ticketNumbers and is not already in cancelledTickets.

            Console.WriteLine("=== Cancel Ticket ===");

            Console.WriteLine("");

            Console.WriteLine("enter ticket ID: ");
            string TicketID = Console.ReadLine();

            if (ticketNumbers.Contains(TicketID) == false) // Check if the TicketID exists in the TicketNumbers  list

            {

                Console.WriteLine("Ticket not found");
                return;
            }

            if (cancelledTickets.Contains(TicketID) == true) // Check if the TicketID is not exists in the CancelTickets

            {

                Console.WriteLine("This ticket has already been cancelled");
                return;
            }

            // req: 2 Retrieve the associated passenger name from passengerNames using the index match.

            int passenger = ticketNumbers.IndexOf(TicketID); // Find the passenger's name by locating the TicketID in
                                                             // ticketNumbers and using the same index in passengerNames

            string PassengerName = passengerNames[passenger];

            // req: 3 If the ticket exists in bookingRecord, remove it from the dictionary and display what booking was removed.

            if (bookingRecord.ContainsKey(TicketID) == true)
            {

                Console.WriteLine($"the TicketID: {bookingRecord.Remove(TicketID)} was removed from bookingrecord successfully!!");

            }
            // req : 4 Add the ticket ID to cancelledTickets.

            if (cancelledTickets.Contains(TicketID) == false)
            {
                cancelledTickets.Add(TicketID); 
                Console.WriteLine($"the TicketID: {TicketID} was removed from bookingrecord successfully!!");

            }

            // req : 5 Check if the passenger name exists in checkedInQueue.If so, rebuild the queue using a temporary Queue, skipping that
            // passenger.Display a notice that they were removed from the check-in queue.

            if (checkedInQueue.Contains(PassengerName) == true) // Check if the passenger exists in the check-in queue

            {
                Queue<string> tempQueue = new Queue<string>();     // Create a temporary queue


                while (checkedInQueue.Count > 0)         // Go through all passengers in the queue


                {
                    string name = checkedInQueue.Dequeue();    // Remove one passenger from the queue


                    if (name != PassengerName)         // Add passenger to temporary queue if it is not the cancelled passenger

                    {
                        tempQueue.Enqueue(name);
                    }
                }

                checkedInQueue = tempQueue;  // Replace the original queue with the updated queue


                Console.WriteLine(PassengerName + " was removed from the check-in queue.");
            }

            // req: 6 Check if the passenger name is in the boardingStack. If so, rebuild the stack using a temporary Stack, preserving order but
            // excluding that passenger. Display a notice.

            
            if (boardingStack.Contains(PassengerName)) // Check if the passenger is in the boarding stack
            {
                Stack<string> tempStack = new Stack<string>();   // Create a temporary stack


                while (boardingStack.Count > 0)  // Go through all passengers in the stack

                {
                    string name = boardingStack.Pop();   // Remove one passenger from the stack


                    if (name != PassengerName) // Add passenger to the temporary stack if it is not the cancelled passenger
                    {
                        tempStack.Push(name);
                    }
                }

                boardingStack = tempStack; // Replace the old stack with the new stack


                Console.WriteLine(PassengerName + " was removed from the boarding stack.");  

            }

            // req: 7 Display a full cancellation summary

            Console.WriteLine("=== Cancellation Summary ===");

            Console.WriteLine("Passenger Name: " + PassengerName);

            Console.WriteLine("Ticket ID: " + TicketID);

            Console.WriteLine("Status: Cancelled");


        }


        //case 7) Passenger Check-In
        // Requirement 1: Sub-menu
        static void CheckInMenu()
        {
            bool back = false;
            while (!back)
            {
                Console.WriteLine("--- Passenger Check-In ---");
                Console.WriteLine("1) Check in a passenger");
                Console.WriteLine("2) View check-in queue");
                Console.WriteLine("3) Process next passenger");
                Console.WriteLine("0) Back");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CheckInPassenger();
                        break;
                    case "2":
                        ViewCheckInQueue();
                        break;
                    case "3":
                        ProcessNextPassenger();
                        break;
                    case "0":
                        back = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        // Requirements 2, 3, 4: Check-in 
        static void CheckInPassenger()
        {
            Console.Write("Enter ticket ID: ");
            string ticketId = Console.ReadLine();

            // Validate ticket exists
            if (!ticketNumbers.Contains(ticketId))
            {
                Console.WriteLine("Error: Ticket ID does not exist.");
                return;
            }

            // Validate not cancelled
            if (cancelledTickets.Contains(ticketId))
            {
                Console.WriteLine("Error: This ticket has been cancelled.");
                return;
            }

            // Confirm booking exists
            if (!bookingRecord.ContainsKey(ticketId))
            {
                Console.WriteLine("Error: No booking record found for this ticket.");
                return;
            }

            // Retrieve passenger name from booking record
            string passengerName = bookingRecord[ticketId].Split('|')[0];

            // Confirm passenger is not already in either queue
            if (checkedInQueue.Contains(passengerName) || waitlistQueue.Contains(passengerName))
            {
                Console.WriteLine($"Error: {passengerName} is already checked in or on the waitlist.");
                return;
            }

            // Requirement 3: queue has space
            if (checkedInQueue.Count < 10)
            {
                checkedInQueue.Enqueue(passengerName);
                Console.WriteLine($"Success: {passengerName} has been checked in. " + $"Position in queue: {checkedInQueue.Count}.");
            }
            // Requirement 4: queue is full
            else
            {
                waitlistQueue.Enqueue(passengerName);
                Console.WriteLine($"Check-in queue is full (10/10). " + $"{passengerName} has been placed on the waitlist.");
            }
        }    

        // Requirement 5: View queue
        static void ViewCheckInQueue()
        {
            Console.WriteLine("--- Current Check-In Queue ---");

            if (checkedInQueue.Count == 0)
            {
                Console.WriteLine("The check-in queue is currently empty.");
            }
            else
            {
                int position = 1;
                foreach (var passenger in checkedInQueue)
                {
                    Console.WriteLine($"Position {position}: {passenger}");
                    position++;
                }
            }

            Console.WriteLine($"Waitlist count: {waitlistQueue.Count}");
        }

        // Requirement 6: Process next passenger
        static void ProcessNextPassenger()
        {
            if (checkedInQueue.Count == 0)
            {
                Console.WriteLine("Check-in queue is empty. No passenger to process.");
                return;
            }

            // Dequeue the front passenger
            string processed = checkedInQueue.Dequeue();
            Console.WriteLine($"Processed passenger: {processed}");

            // Automatically move a waitlisted passenger into the now-open slot
            if (waitlistQueue.Count > 0)
            {
                string moved = waitlistQueue.Dequeue();
                checkedInQueue.Enqueue(moved);
                Console.WriteLine($"{moved} has been moved from the waitlist to the check-in queue.");
            }
        }

















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
                        UpdateBooking();
                        break;



                    //case 6) Cancel a Ticket
                    case 6:
                        CancelTicket();
                        break; 


                    //case 7) Passenger Check-In
                    case 7:
                        CheckInMenu();
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
