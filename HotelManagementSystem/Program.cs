namespace HotelManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ALL variables


            string guestName = "";
            string guestPhone = "";
            int roomNumber = 0;
            string roomType = "";
            double nightlyRate = 0;

            DateTime checkInDate = DateTime.Today;
            DateTime checkOutDate = DateTime.Today;

            int numberOfNights = 0;

            string roomNotes = "";

            double discountPercentage = 0;

            double totalBill = 0;

            int loyaltyPoints = 0;

            bool isguestRegistered = false;
            bool isguestCheckedIn = false;
            Random random = new Random();
            int choice;
            bool exit = false;
            while (exit == false)
            {





                Console.WriteLine("=================================");
                Console.WriteLine(" GRAND PALACE HOTEL");
                Console.WriteLine("=================================");

                Console.WriteLine("0. Register New Guest");
                Console.WriteLine("1. View Guest Information");
                Console.WriteLine("2. Check-In Guest");
                Console.WriteLine("3. Check-Out & Bill");
                Console.WriteLine("4. Apply Discount");
                Console.WriteLine("5. Upgrade Room");
                Console.WriteLine("6. Add Room Service Note");
                Console.WriteLine("7. Search Guest by Name");
                Console.WriteLine("8. Calculate Loyalty Points");
                Console.WriteLine("9. Print Receipt");
                Console.WriteLine("10. Edit Guest Name");
                Console.WriteLine("11. Exit");

                Console.WriteLine("enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {



                    //Register New Gues
                    case 0:
                        Console.WriteLine("enter Guest Name: ");
                        guestName = Console.ReadLine().Trim();
                        Console.WriteLine("enter Guest Number:");
                        guestPhone = Console.ReadLine().Trim();
                        Console.WriteLine("enter room Type: ");
                        roomType = Console.ReadLine().Trim();

                        roomNumber = random.Next(1, 999);

                        isguestRegistered = true;
                        Console.WriteLine("guest rigestered Successfully");
                        Console.WriteLine("Room Number" + roomNumber);


                        break;

                    //View Guest Information
                    case 1:
                        if (isguestRegistered == false)
                        {
                            Console.WriteLine("There is no information");

                        }
                           else
                    {
                        Console.WriteLine("Guest Name      : " + guestName.ToUpper());
                        Console.WriteLine("Phone Number    : " + Convert.ToString(guestPhone));
                        Console.WriteLine("Room Number     : " + Convert.ToString(roomNumber));
                        Console.WriteLine("Room Type       : " + roomType);
                        Console.WriteLine("Nightly Rate    : " + Math.Round(nightlyRate));
                        Console.WriteLine("Discount        : " + discountPercentage + "%");
                        Console.WriteLine("Loyalty Points  : " + Convert.ToString(loyaltyPoints));
                        Console.WriteLine("Checked In      : " + isguestCheckedIn);
                        Console.WriteLine("Check-In Date   : " + checkInDate);
                        Console.WriteLine("Check-Out Date  : " + checkOutDate);
                        Console.WriteLine("Room Notes      : " + roomNotes);
                    }


                        break;

                    //Check-In Guest
                    case 2:
                        if (isguestRegistered == false)
                        {
                            Console.WriteLine("please register first");
                        }
                        else
                        {
                            Console.WriteLine("enter number of nights: ");
                        }
                       numberOfNights= Convert.ToInt32(Console.ReadLine());

                        checkInDate = DateTime.Now;
                        checkOutDate = DateTime.Today.AddDays(numberOfNights);

                        if (isguestCheckedIn == true)

                            Console.WriteLine("guest checked successfully");
                        Console.WriteLine("Check in date: " + checkInDate);
                        Console.WriteLine("Check out date: " + checkOutDate);

                        break;

                    //Check-Out & Bill
                    case 3:
                        if (isguestCheckedIn == false)
                        {
                            Console.WriteLine("No guest cheked in");

                        }
                        else
                        {




                        }


                        break;


                    //Apply Discount
                    case 4:
                        Console.WriteLine("");
                        break;


                    //Upgrade Room
                    case 5:
                        Console.WriteLine("");
                        break;


                    //Add Room Service Note
                    case 6:
                        Console.WriteLine("");
                        break;


                    //Search Guest by Name
                    case 7:
                        Console.WriteLine("");
                        break;


                    //Calculate Loyalty Points
                    case 8:
                        Console.WriteLine("");
                        break;

                    //Print Receipt
                    case 9:
                        Console.WriteLine("");
                        break;


                    //Edit Guest Name
                    case 10:
                        Console.WriteLine("");
                        break;


                    //Exit
                    case 11:
                        Console.WriteLine("");
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
