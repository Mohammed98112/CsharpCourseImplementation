using static System.Net.WebRequestMethods;

namespace queue_and__stack
{
    internal class Program
    {

        //Problem 1: Browser History Tracker
        public static void problrm1()
        {

            Stack<string> browserHistory = new Stack<string>();

            browserHistory.Push("https://www.google.com");
            browserHistory.Push("https://www.youtube.com");
            browserHistory.Push("https://github.com/Mohammed98112/CsharpCourseImplementation");
            browserHistory.Push("https://chatgpt.com/");
            browserHistory.Push("https://www.geeksforgeeks.org/");

            Console.WriteLine("browsing History: ");

            foreach (string page in browserHistory)
            {
                Console.WriteLine(page);

            }

            Console.WriteLine("");

            var PageDisplay = browserHistory.Peek();
            Console.WriteLine($"\the page is after peek: {PageDisplay }");

            Console.WriteLine("");

            var removedpage = browserHistory.Pop();
            Console.WriteLine($"\nPopped page: {removedpage}");

            Console.WriteLine("");

            var removedpage2 = browserHistory.Pop();
            Console.WriteLine($"\nPopped page: {removedpage2}");

            Console.WriteLine("");


            Console.WriteLine("browsing History after popped: ");

            foreach (string pages in browserHistory)
            {
                Console.WriteLine(pages);

            }

            Console.WriteLine("");

            string searchUrl = "https://chatgpt.com";
            Console.WriteLine("Checking URL:");
            Console.WriteLine(searchUrl + " exists: " +  browserHistory.Contains(searchUrl));

            Console.WriteLine("");

            Console.WriteLine("\nTotal Pages Remaining: " + browserHistory.Count);
        }

        //Problem 2: Hotel Check-In Queue
        public static void problrm2()
        {

            Queue<string> checkInQueue = new Queue<string>();

            checkInQueue.Enqueue("Ahmed");
            checkInQueue.Enqueue("JohnWick");
            checkInQueue.Enqueue("Messi");
            checkInQueue.Enqueue("davinci");
            checkInQueue.Enqueue("MR.Bean");


            Console.WriteLine("");

            Console.WriteLine("guest Name: ");

            foreach (string guest in checkInQueue)
            {
                Console.WriteLine(guest);

            }

            Console.WriteLine("");

            var GuestDisplay = checkInQueue.Peek();
            Console.WriteLine($"guest peek: {GuestDisplay}");

            Console.WriteLine("");

            string removedGuest = checkInQueue.Dequeue();
            Console.WriteLine($"removed Guest: {removedGuest}");

            Console.WriteLine("");

            string removedGuest2 = checkInQueue.Dequeue();
            Console.WriteLine($"Removed Guest: {removedGuest2}");

            Console.WriteLine("");


            Console.WriteLine("The remaining guests after dequeue: ");

            foreach (string guests in checkInQueue)
            {
                Console.WriteLine(guests);

            }

            Console.WriteLine("");

            string searchUrl = "Messi";
            Console.WriteLine("Checking Guest:");
            Console.WriteLine(searchUrl + " exists: " + checkInQueue.Contains(searchUrl));


            Console.WriteLine("");

            Console.WriteLine("\nTotal Pages Remaining: " + checkInQueue.Count);

        }

        public static int mainmenue()
        {

            Console.WriteLine("=================================");
            Console.WriteLine(" QUEUE and STACK Practice Task Sheet");
            Console.WriteLine("=================================");

            Console.WriteLine("0. Problem 1: Browser History Tracker");
            Console.WriteLine("1. Problem 2: Hotel Check-In Queue");
            Console.WriteLine("2. Problem 3: Text Editor Undo System");
            Console.WriteLine("3. Problem 4: Hospital Emergency Room Triage");
            Console.WriteLine("4. Problem 5: Parenthesis Validator ");
            Console.WriteLine("5. Problem 6: Print Spooler with Priority Re-Insertion");
            Console.WriteLine("6. Problem 7: Reverse a Sentence Word by Word");
            Console.WriteLine("7. Problem 8: Multi-Level Undo with Redo");
            Console.WriteLine("8. Problem 9: Ticket Counter Simulation");
            Console.WriteLine("9. Problem 10: Order Processing Pipeline with Statistics ");
            Console.WriteLine("10. exit");
            Console.WriteLine("=================================");

            Console.WriteLine("enter your choice: ");

            return Convert.ToInt32(Console.ReadLine());


        }




        static void Main(string[] args)
        {
            bool exit = false;
            while (exit == false)
            {
                switch (mainmenue())
                {



                    //Problem 1: Browser History Tracker
                    case 0:
                        problrm1();
                        break;



                    //Problem 2: Hotel Check-In Queue 
                    case 1:
                        problrm2();
                        break;


                    //Problem 3: Text Editor Undo System 
                    case 2:
                        
                        break;


                    //Problem 4: Hospital Emergency Room Triage
                    case 3:
                        
                        break;



                    //Problem 5: Parenthesis Validator 
                    case 4:

                        break;


                    //Problem 6: Print Spooler with Priority Re-Insertion
                    case 5:

                        break;



                    //Problem 7: Reverse a Sentence Word by Word 
                    case 6:

                        break;


                    //Problem 8: Multi-Level Undo with Redo
                    case 7:
                        break;


                    //Problem 9: Ticket Counter Simulation 
                    case 8:
                        break;

                    //Hospital Patient Priority Queue
                    case 9:
                        break;


                    //Problem 10: Order Processing Pipeline with Statistics
                    case 10:
                        break;

                    //Exit
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
