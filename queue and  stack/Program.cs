namespace queue_and__stack
{
    internal class Program
    {


        public static int mainmenue()
        {

            Console.WriteLine("=================================");
            Console.WriteLine(" Arrays Practice Task Sheet");
            Console.WriteLine("=================================");

            Console.WriteLine("0. Temperature Log");
            Console.WriteLine("1. Student Score Board");
            Console.WriteLine("2. Product Price Finder");
            Console.WriteLine("3. Race Finish Times");
            Console.WriteLine("4. Classroom Grade Report ");
            Console.WriteLine("5. Warehouse Inventory Check");
            Console.WriteLine("6. Library Book Shelf Scanner");
            Console.WriteLine("7. Sales Performance Analyzer");
            Console.WriteLine("8. Flight Seat Allocation Display");
            Console.WriteLine("9. Hospital Patient Priority Queue");
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
                        
                        break;



                    //Problem 2: Hotel Check-In Queue 
                    case 1:
                        
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
