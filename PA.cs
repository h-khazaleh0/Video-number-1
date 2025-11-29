
namespace ex1
{
    public class Name
    {
        public static string? readName()
        {
            Console.WriteLine("Enter your name:");
            string? name = Console.ReadLine();
            return name;
        }
        public static void printName()
        {
            string? name = readName();
            Console.WriteLine("Your name is: " + name);
        }
    }
}
