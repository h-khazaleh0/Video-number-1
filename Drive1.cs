namespace ex1
{
    public class Drive1
    {
        public static int Readage()
        {
            Console.WriteLine("Enter your rage level (0-100):");
            int rageLevel = Convert.ToInt32(Console.ReadLine());
            return rageLevel;
        }
        public static bool DdriverLicense ()
        {
            Console.WriteLine("Do you have a driver's license? (1 for Yes, 0 for No):");
            bool driverLicense = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
            return driverLicense;
        }


        public static void Wage_()
        {
            int rageLevel = Readage();
            bool driverLicense = DdriverLicense();
            if (rageLevel >= 18 && driverLicense == true)
            {
                Console.WriteLine("Hired");
            }
            else
            {
                Console.WriteLine("Rejected");
            }

        }
    }
}
