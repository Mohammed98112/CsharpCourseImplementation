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
        }

            //display member
        public static void DisplayMember()
        {


            if (isMemberRegistered == false)
            {
                Console.WriteLine("There is no information");

            }
            else
            {
                Console.WriteLine("memberName     : " + memberName.ToUpper());
                Console.WriteLine("memberID    : " + Convert.ToString(memberID));
                Console.WriteLine("memberEmail     : " + Convert.ToString(memberEmail));
                Console.WriteLine("membershipExpiry       : " + membershipExpiry);
                Console.WriteLine("memberTier    : " + memberTier);

            }


        }

        public static bool SearchBookByTitle(string Search)
        {






            if (Search.ToLower() != bookTitle)
            {
                return false;
            }

            else
            {
                return true;
            }




        }

        // Borrows a book using ref parameter function
        public static void BorrowBook(ref int copies)
        {
            if (copies <= 0)
            {
                Console.WriteLine("No copies available.");
                return;
            }

            copies--;

            Console.WriteLine("You borrowed: " + bookTitle);
            Console.WriteLine("Book Borrowed Successfully!");
        }



            // Returns a book using ref parameter
            static void ReturnBook(ref int copies)
            {
                copies = Math.Min(100, copies + 1);

                Console.WriteLine("Book Returned Successfully!");
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



                        //Display Member Profile
                        case 1:

                            DisplayMember();

                            break;


                    //Search Book by Title
                    case 2:
                        if (isMemberRegistered == false)
                        {
                            Console.WriteLine("please register first");
                        }
                        else
                        {

                            Console.WriteLine("enter Book title you want: ");
                            if (SearchBookByTitle(Console.ReadLine()) == true)
                            {

                                Console.WriteLine("the book is found");

                            }
                            else
                            {

                                Console.WriteLine("the book is not found");


                            }

                        }
                        break;


                    //Borrow a Book
                    case 3:

                        BorrowBook(ref availableCopies);
                        break;



                    //Return a Book
                    case 4:
                        ReturnBook(ref availableCopies);


                        break;


                    //Calculate Late Fine
                    case 5:
                        Console.WriteLine("");
                        break;


                    //Apply Member Discount
                    case 6:
                        Console.WriteLine("");
                        break;


                    //Check Borrowing Eligibility
                    case 7:
                        Console.WriteLine("");
                        break;


                    //Register Book
                    case 8:
                        Console.WriteLine("");
                        break;

                    //Generate Member ID
                    case 9:
                        Console.WriteLine("");
                        break;


                    //Display Book Details
                    case 10:
                        Console.WriteLine("");
                        break;


                    //Calculate Renewal Fee
                    case 11:
                        Console.WriteLine("");
                        break;


                    //Update Member Email
                    case 12:
                        Console.WriteLine("");
                        break;

                    //Session Summary
                    case 13:
                        Console.WriteLine("");
                        break;
                    //Exit
                    case 14:
                        exit = true;
                        break;


                    //wrong option
                    default:
                        Console.WriteLine("invalid option");
                        break;

                }
                Console.WriteLine("press any key to continue...");
                Console.ReadKey();
            
            }
        }
    }
}
                
            
        
    

               