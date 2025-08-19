namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            string temp;

            // If a person is older than 14 and younger than 18
            // if a person is older than 18 and younger than 21
            // Anyone else (older than 21)

            while (true)
            {
                // Request a value from the user (as a string)
                Console.WriteLine("Enter your age: ");
                
                // Converted the user value (string) to an integer value
                temp = Console.ReadLine();
                
                age = Convert.ToInt32(temp);


                if ( (age > 0) && (age < 14 ) ) // 0 - 13
                {
                    Console.WriteLine("You are still a baby :)");
                }
                else if ((age >= 14) && (age < 18)) // 14 - 17 
                {
                    Console.WriteLine("You are a minor!");
                }
                else
                {
                    Console.WriteLine("You are an adult!");
                }
            }
        }
    }
}
