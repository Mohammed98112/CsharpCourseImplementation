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

            bool guestRegistered = false;
            bool guestCheckedIn = false;

            //Random random = new Random();

            int choice;

            while (true)
            {

                Console.Clear();

                Console.WriteLine("=================================");
                Console.WriteLine(" GRAND PALACE HOTEL");
                Console.WriteLine(" Front Desk Console");
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
                        Console.WriteLine("");
                        break;

                    //View Guest Information
                    case 1:
                        Console.WriteLine("");
                        break;

                    //Check-In Guest
                    case 2:
                        Console.WriteLine("");
                        break;

                    //Check-Out & Bill
                    case 3:
                        Console.WriteLine("");
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






                }










            }

        }
    }
}
