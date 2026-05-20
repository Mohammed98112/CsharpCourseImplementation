using System.Reflection.Metadata;

namespace Library_Management_System
{
    internal class Program
    {

        // Member Information
        static string memberName = "";
        static string memberID = "";
        static string memberEmail = "";
        static string membershipExpiry = "";
        static string memberTier = "";

        // Member Status
        static bool isMemberRegistered = false;

        // Book Information
        static string bookTitle = "";
        static string bookAuthor = "";
        static string bookGenre = "";

        // Book Copies
        static int availableCopies = 0;

        // Book Status
        static bool isBookRegistered = false;

        // Session Statistics
        static double totalBooksBorrowed = 0;
        static double totalFinesPaid = 0;


        //register new member
        public static void Newmember()
        {
            if (isMemberRegistered == false)
            {
                Console.WriteLine("enter member Name: ");
                memberName = Console.ReadLine().Trim();
                Console.WriteLine("enter member ID: ");
                memberID = Console.ReadLine().Trim();
                Console.WriteLine("enter Member Email: ");
                memberEmail = Console.ReadLine().Trim();
                Console.WriteLine("enter membershipExpiry (Year/Month/Day): ");
                membershipExpiry = Console.ReadLine().Trim();
                Console.WriteLine("enter memberTier: ");
                memberTier = Console.ReadLine().Trim();

                isMemberRegistered = true;
                Console.WriteLine("Member rigestered Successfully");
            }

            else
            {
                Console.WriteLine("cannot register again");


            }

            static void Main(string[] args)
            {
                bool exit = false;
                while (exit == false)
                {
                    Console.WriteLine("=================================");
                    Console.WriteLine(" Library Management System");
                    Console.WriteLine(" Welcome to the best Library");
                    Console.WriteLine("=================================");

                    Console.WriteLine("0. Register New member");
                    Console.WriteLine("1. Display Member Profile");
                    Console.WriteLine("2. Search Book by Title)");
                    Console.WriteLine("3. Borrow a Book");
                    Console.WriteLine("4. Return a Book");
                    Console.WriteLine("5. Calculate Late Fine");
                    Console.WriteLine("6. Apply Member Discount");
                    Console.WriteLine("7. Check Borrowing Eligibility");
                    Console.WriteLine("8. Register Book");
                    Console.WriteLine("9. Generate Member ID");
                    Console.WriteLine("10. Display Book Details");
                    Console.WriteLine("11. Calculate Renewal Fee");
                    Console.WriteLine("12. Update Member Email");
                    Console.WriteLine("13. Session Summary");
                    Console.WriteLine("14. exit");
                    Console.WriteLine("=================================");

                    int choice;
                    Console.WriteLine("enter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {



                        //Register New member
                        case 0:
                            Newmember();


                            break;
                    }
                }
            }
        }
    }
}
                
            
        
    

               