namespace Collections
{
    internal class Program
    {

        //case 0 Temperature Log 
        public static void temp()
        {

            double[] tempreture = new double[] { 5, 25, 24, 78, 88, 77, 64 };

            for (int i = 0; i < tempreture.Length; i++)
            {

                Console.WriteLine("the temp is: " + (i+1) );
                Console.WriteLine(tempreture[i]);

            }

        }

        public static void StudentScoreBoard()
        {

            int[] scores = new int[] { 40, 50, 88, 66, 45, 60 };


            for (int i = 0;i < scores.Length;i++)
            {

                Console.WriteLine("the temp is: " + (i + 1));
                Console.WriteLine(scores[i]);
                Array.Reverse(scores);
            }
        }

        public static void prodectPrice()
        {

            double[] price = new double[] { 1.8, 2.77, 2.1, 7.65, 3.3};


            int index = Array.IndexOf(price, 5);
            if (index == -1)
            {

                Console.WriteLine("item not found in Array");

            }

            else
            {

                Console.WriteLine("item  found in Array: " + index );

            }

        }



        static void Main(string[] args)
            {
                bool exit = false;
                while (exit == false)
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


                int choice;
                    Console.WriteLine("enter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {

                    //Temperature Log
                    case 0:

                        temp();
                            break;



                    //Student Score Board
                    case 1:
                        StudentScoreBoard();
                            break;


                    //Product Price Finder
                    case 2:
                        prodectPrice();
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

                }
            }
        }
    }


    
