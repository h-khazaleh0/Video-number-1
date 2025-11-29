namespace ex1
{
    public class OddEven
    {
        public static int lkjvyhvb()
        {
            Console.WriteLine("Enter a number:");
            int input = Convert.ToInt32(Console.ReadLine());
            return input;

        }
        public static void lkjvyhvb_()
        {
            int input = lkjvyhvb();
            if (input % 2 == 0)
            {
                Console.WriteLine($"The number is even ==> {input}");
            }
            else
            {
                Console.WriteLine($"The number is odd ==> {input}");
            }
            
        }
    }
}
