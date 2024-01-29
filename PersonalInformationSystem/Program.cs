namespace PersonalInformationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declare Variables for Personal Information
            string name;

            int age;
            double doubleAge;
   
            double height;
          
            string newInformation = "Y";

            // Start a do-while loop for the Personal Information System to run repeatedly
            do
            {
                // Display a title for the Personal Information System
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("|              Personal Information System                     |");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("Welcome to Your Personal Information System! \n");


                // Added declaration for invalid for non-numeric input
                int invalidInput = 0;

                // Use a while loop for input validation (accept only numeric input in Age and Height)
                while (invalidInput == 0)
                {
                    try
                    {

                        // Prompt user for information
                        Console.WriteLine("Please fillin the needed information below:");
                        Console.Write("Please enter your name: ");
                        name = Convert.ToString(Console.ReadLine());

                        // Validate and input age
                        //Use a while loop to return validation for input less than 0 or negative numeric values for Age and Height
                        Console.Write("Please enter your age: ");
                        doubleAge = Convert.ToDouble(Console.ReadLine());
                        while (doubleAge <= 0)
                        {
                            // Handle invalid input for age
                            Console.WriteLine("Invalid Input! Please enter a non-negative and zero numeric value.");
                            Console.Write("\nPlease enter your age: ");
                            age = Convert.ToInt32((Console.ReadLine()));
                            doubleAge = Convert.ToDouble(age);
                            
                        }

                        // Validate and input height
                        Console.Write("Please enter your height in meters: ");
                        height = (double)Convert.ToDouble(Console.ReadLine());
 
                        while (height <= 0)
                        {
                            // Handle invalid input for height
                            Console.WriteLine("Invalid Input! Please enter a non-negative and zero numeric value.");
                            Console.Write("\nPlease enter your height in meters: ");
                            height = Convert.ToDouble(Console.ReadLine());
                        }

                        // Display personal information
                        // Added string variable named personalInfo that includes the person's name, age, and height.
                        Console.WriteLine("---------------------------------------------------------------");
                        string personalInfo = $"\nYour Personal Details: \r\nName: {name} \r\nAge: {doubleAge} \r\nHeight: {height} meters\n\n";
                        Console.WriteLine(personalInfo);

                        // Addedd string variable named ageCheck and added conditional (ternary) operator for age
                        string ageCheck = "Age Check: ";
                        Console.Write(doubleAge >= 18 ? $"{ageCheck}\r\nWelcome to the adult section, {name}!\r\n" : $"{ageCheck}\r\nSorry {name}! You are still a minor.\r\n");


                        // Addedd constant named LEGAL_DRINKING_AGE with a value of 21 and conditional (ternary) operator for Age 21.
                        const double LEGAL_DRINKING_AGE = 21;
                        string ageVerification = "Legal Drinking Age Verification: ";
                        Console.Write(doubleAge >= LEGAL_DRINKING_AGE ? $"\n{ageVerification}\r\nCheers, {name}! You are legally allowed to drink.\r\n" : $"\n{ageVerification}\r\nSorry {name}! You are underage for drinking.\r\n");


                        string personalInfo1 = personalInfo;
                        personalInfo1 = $"\nYour Personal Information: {name}, {doubleAge} years old, {height} meters tall.\n\n";
                        Console.WriteLine(personalInfo1);
                        // Console.WriteLine($"\nYour Personal Information: {name}, {doubleAge} years old, {height} meters tall.\n\n");
                        Console.WriteLine("\nThank you for using Your Personal Information System!\n");
                        Console.WriteLine("---------------------------------------------------------------");
                        invalidInput = 1;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid input!\n\n");
                        invalidInput = 0;
                    }

                }

                // Prompt the user to continue or exit
                Console.Write("Enter 'y' to continue, press 'Enter' twice to exit.: ");
                newInformation = Console.ReadLine();
                Console.Write("\n\n");
            }
            while (newInformation == "y" || newInformation == "Y");

        }
    }
}
