namespace Listpractice
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
            Console.WriteLine("2. Product Price Finder)");
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

        public static void  Temp()
        {

            List<int> numbers = new List<int>();
            numbers.AddRange(new int[] { 88, 44, 66, 65, 20, 85, 10 });

            Console.WriteLine("All elements:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("number of all elements is: " + numbers.Count);
        }

        public static void scores()
        {

            List<int> scores = new List<int>();
            scores.AddRange(new int[] { 90, 44, 66, 65, 20, 85, });
            

            Console.WriteLine("All scores :");
            foreach (int number in scores)
            {
                Console.WriteLine(number);
                
            }

            scores.Reverse();
            foreach (int number in scores)
            {
                Console.WriteLine("reverse order: "+number);

            }
       

           
        }

        static void Main(string[] args)
        {
            bool exit = false;
            while (exit == false)
            {


                switch (mainmenue())
                {

                    //Temperature Log
                    case 0:
                        Temp();
                        break;



                    //Student Score Board
                    case 1:
                        scores();
                        break;


                    //Product Price Finder
                    case 2:
                        break;


                    //Race Finish Times
                    case 3:
                        break;



                    //Classroom Grade Report 
                    case 4:

                        break;


                    //Warehouse Inventory Check
                    case 5:

                        break;



                    //Library Book Shelf Scanner
                    case 6:

                        break;


                    //Sales Performance Analyzer 
                    case 7:
                        break;


                    //Flight Seat Allocation Display 
                    case 8:
                        break;

                    //Hospital Patient Priority Queue
                    case 9:
                        break;


                    //Exit
                    case 10:
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

    

