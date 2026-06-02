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
    }



}  

