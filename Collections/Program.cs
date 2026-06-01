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
        static void Main(string[] args)
        {
        }
    }
}
