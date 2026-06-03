using System.Diagnostics;
using System.Numerics;

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

        public static void  Temp()
        {

            List<double> tempreture = new List<double>();
            tempreture.AddRange(new double[] { 34.2,35.1,36.6,33.1,32.9,34,36 });

            for (int i = 0; i < tempreture.Count; i++)

            {
                Console.WriteLine($"day {i+1} tempreture {tempreture[i]} C");
            }

            Console.WriteLine("total number of reading:" + tempreture.Count );
           
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




        public static void ProductPriceFinder()
        {

            List<double> prices = new List<double>();
            prices.AddRange(new double[] { 90.5, 44.7, 66.11, 65.8, 20.3 });

            for (int i = 0; i < prices.Count; i++)
            {

                Console.WriteLine($"product {i + 1}  {prices[i]}");
            }

            double search = 44.7;
            int index = prices.IndexOf (search);

            if (index != -1)
            {
                Console.WriteLine($"price found at index {index}");
                
            }

            else
            {

                Console.WriteLine("price not found");
                
                
            }


        }

        //Race Finish Times case 3
        public static void RaceFinishTimes()
        {

            List<int> finishTimes = new List<int>();
            finishTimes.AddRange(new int[] { 90, 44, 66, 65, 20, 85, });

            Console.WriteLine(" the orignal finish times:");

            foreach (int i in finishTimes)
            {

                Console.WriteLine(i);

            }

            finishTimes.Sort();
            Console.WriteLine(" the sorted finish times:");

            foreach (int i in finishTimes)
            {

                Console.WriteLine(i);

            }

        }

        //Classroom Grade Report case 4
        public static void ClassroomGradeReport()
        {


            List<int> grades = new List<int>();
            grades.AddRange(new int[] { 90, 44, 66, 65, 20, 85, });

            grades.Sort();
            grades.Reverse();

            for (int i = 0; i < grades.Count; i++)
            {

                Console.WriteLine($"Rank {i + 1}: {grades[i]}");

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
                        ProductPriceFinder();
                        break;


                    //Race Finish Times
                    case 3:
                        RaceFinishTimes();
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

    

