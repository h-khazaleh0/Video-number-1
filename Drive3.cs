namespace ex1
{
    public class Drive3
    {
        public static int Readage()
        {
            Console.WriteLine("Enter your Has Age level (0-100):");
            int rageLevel = Convert.ToInt32(Console.ReadLine());
            return rageLevel;
        }
        public static bool DdriverLicense()
        {
            Console.WriteLine("Do you have a Has Driver's license? (1 for Yes, 0 for No):");
            bool driverLicense = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
            return driverLicense;
        }
        public static bool Recommendation()
        {
            Console.WriteLine("Do you have a Recommendation letter? (1 for Yes, 0 for No):");
            bool recommendatio = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
            return recommendatio;
        }


        public static void Wage_()
        {
            int rageLevel = Readage();
            bool driverLicense = DdriverLicense();
            bool recommendatio = Recommendation();
            if (recommendatio == true || (rageLevel >= 18 && driverLicense == true))
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
