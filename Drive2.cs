using System;

namespace ex1
{
    //طريقه 2 باستخدام struct ولاكنها صعبه 
    public class Drive2
    {
        public struct stInfo
        {
            public int age;
            public bool hasDriverLicense;
        }

        public static stInfo ReadInfo()
        {
            // ... (rest of the code is correct)
            stInfo Info;
            Console.WriteLine("Enter your age:");
            Info.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you have a driver's license? (1 for Yes, 0 for No):");
            Info.hasDriverLicense = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
            return Info;
        }
        public bool ISAccepted(stInfo Info)
        {
            return (Info.age >= 18 && Info.hasDriverLicense);

        }
        public void PrintResult(stInfo Info)
        {

            if (ISAccepted(Info))
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