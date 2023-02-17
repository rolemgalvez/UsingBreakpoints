namespace HomeworkTwelve
{
    public class Section
    {
        public static void Welcome()
        {
            Console.WriteLine("Homework Twelve");
            Console.WriteLine("---------------");
        }

        public static void Main()
        {
            double total = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"i = {i}");
                
                double product = i * 5;
                Console.WriteLine($"product = {product}");

                total += product;
                Console.WriteLine($"total = {total}");
            }
        }

        public static void End()
        {
            Console.WriteLine();
            Console.WriteLine("End of program.");
            Console.ReadLine();
        }
    }
}
