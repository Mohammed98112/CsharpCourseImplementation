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
        static string memberTier = "gold";

        // Member Status
        static bool isMemberRegistered = true;

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



        //All functions 

        //case 0 register new member 
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

        //case 1 display member information
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

        //case 2 search book by title
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

        // case 3 Borrows a book 
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



            // case 4 Returns a book using ref parameter
           public static void ReturnBook(ref int copies)
            {
                copies = Math.Min(100, copies + 1);

                Console.WriteLine("Book Returned Successfully!");
            }

        // case 5 calculate late fine
        public static double CalculateLateFine(int lateDays)
        {
            double fine = lateDays * 0.5;
            totalFinesPaid += fine;
            return fine;
        }

        // case 6 member discount
        public static double MemberDiscount(double price)
        {
            if (memberTier.ToLower() == "gold")
            {
                return price * (1 - 0.2);
            }
            else if (memberTier.ToLower() == "silver")
            {
                return price * (1 - 0.1);
            }
            else

            {
                return price * (1 - 0.01);
            }
        }

        // case 7 Check borrowing eligibility
        public static bool CheckBorrowingEligibility()
        {
            if (isMemberRegistered == false)
            {
                Console.WriteLine("please register first");
                return false;
            }
            else
            {
                DateTime expiryDate = DateTime.Parse(membershipExpiry);
                if (DateTime.Now > expiryDate)
                {
                    Console.WriteLine("Membership expired. Please renew.");
                    return false;
                }
                return true;
            }
        }

        // case 8 Register Book
        public static void RegisterBook()
        {
            if (isBookRegistered == false)
            {
                Console.WriteLine("enter book title: ");
                bookTitle = Console.ReadLine().Trim();
                Console.WriteLine("enter book author: ");
                bookAuthor = Console.ReadLine().Trim();
                Console.WriteLine("enter book genre: ");
                bookGenre = Console.ReadLine().Trim();
                Console.WriteLine("enter available copies: ");
                availableCopies = Convert.ToInt32(Console.ReadLine().Trim());


                isBookRegistered = true;
                Console.WriteLine("Book registered Successfully");
            }
            else
            {
                Console.WriteLine("cannot register again");
            }
        }

        // case 9 generate member ID
        public static string GenerateMemberID()
        {
            if (isMemberRegistered == false)
            {
                Console.WriteLine("please register first");
                return "";
            }
            else
            {
                memberID = new Random().Next(1000, 9999).ToString();
                Console.WriteLine("Generated Member ID: " + memberID);
                return memberID;
            }
        }


        // case 10 Display Book Details
        public static void DisplayBookDetails()
        {
            if (isBookRegistered == false)
            {
                Console.WriteLine("There is no information");
            }
            else
            {
                Console.WriteLine("bookTitle     : " + bookTitle.ToUpper());
                Console.WriteLine("bookAuthor    : " + Convert.ToString(bookAuthor));
                Console.WriteLine("bookGenre     : " + Convert.ToString(bookGenre));
                Console.WriteLine("availableCopies       : " + availableCopies);
            }
        }

     

        // case 11 Calculate Renewal Fee
        public static double CalculateRenewalFee()
        {
            double baseFee = 20.0;

            if (memberTier.ToLower() == "gold")
            {
                return baseFee - (baseFee * 0.20); // 20% discount

            }
            else if (memberTier.ToLower() == "silver")
            {
                return baseFee - (baseFee * 0.10); // 10% discount
            }
            else
            {
                return baseFee;
            }
        }

        // case 12 update member email
        public static void updatememberemail()
        {

            if (isMemberRegistered == false)
                Console.WriteLine("please register first");

            else
            {
                Console.Write("Enter new email: ");
                memberEmail = Console.ReadLine().Trim();

                Console.WriteLine("Email updated successfully.");
            }
        }

        // case 13 summary
        public static void DisplaySessionSummary()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("        SESSION SUMMARY");
            Console.WriteLine("=================================");

            if (isMemberRegistered)
            {
                Console.WriteLine("Member Name      : " + memberName);
                Console.WriteLine("Member ID        : " + memberID);
                Console.WriteLine("Member Tier      : " + memberTier);
                Console.WriteLine("Member email      : " + memberEmail);
            }
            else
            {
                Console.WriteLine("No member registered.");
            }

            Console.WriteLine();

            if (isBookRegistered)
            {
                Console.WriteLine("Book Title       : " + bookTitle);
                Console.WriteLine("Book Author      : " + bookAuthor);
                Console.WriteLine("Available Copies : " + availableCopies);
            }
            else
            {
                Console.WriteLine("No book registered.");
            }

            Console.WriteLine();

            Console.WriteLine("Total Books Borrowed : " + totalBooksBorrowed);
            Console.WriteLine("Total Fines Paid     : $" + totalFinesPaid);

            Console.WriteLine("=================================");
        }

        //case 14 exit..

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


                    //calculate late fine
                    case 5:
                        if (isMemberRegistered == false)
                        {
                            Console.WriteLine("please register first");
                        }
                        else
                        {
                            Console.WriteLine("enter the number of late days: ");
                            int lateDays = Convert.ToInt32(Console.ReadLine());
                            double fine = CalculateLateFine(lateDays);
                            Console.WriteLine("Late Fine: $" + fine);
                        }


                        break;



                    //Apply Member discount
                    case 6:
                        if (isMemberRegistered == false)
                        {
                            Console.WriteLine("please register first");
                        }
                        else
                        {
                            Console.WriteLine("enter the book price: ");
                            double price = Convert.ToDouble(Console.ReadLine());
                            double discountedPrice = MemberDiscount(price);
                            Console.WriteLine("Discounted Price: $" + discountedPrice);
                        }

                        break;


                    //Check borrowing eligibility
                    case 7:
                        CheckBorrowingEligibility();
                        break;


                    //Register Book
                    case 8:
                        RegisterBook();
                        break;

                    //Generate Member ID
                    case 9:
                        GenerateMemberID();
                        break;


                    //Display Book Details
                    case 10:
                        DisplayBookDetails();
                        break;


                    //Calculate Renewal Fee
                    case 11:

                        Console.WriteLine($"renawel fee is: {CalculateRenewalFee()}");



                        break;


                    //Update Member Email
                    case 12:
                        updatememberemail();
                        break;

                    //Session Summary
                    case 13:
                        DisplaySessionSummary();

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
                
            
        
    

               