namespace theswitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Enter the day of the Week (1-7): ");
                int theday = Convert.ToInt32(Console.ReadLine());

                string usersday = theday switch
                {
                    1 => "Monday",
                    2 => "Tuesday",
                    3 => "Wednesday",
                    4 => "Thursday",
                    5 => "Friday",
                    _ => "Pick a day dude"
                };

                Console.WriteLine(usersday);
            };


            //    switch (theday)
            //    {
            //        case 1:
            //            Console.WriteLine("Happy monday");
            //            break;

            //        case 2:
            //            Console.WriteLine("Day 2 of 7...");
            //            break;

            //        case 3:
            //            Console.WriteLine("You are now at day " + theday + " of 7...");
            //            break;

            //        default:
            //            Console.WriteLine("Dude pick a day");
            //            break;
            //    }
            //}



            //Console.WriteLine("Enter the day of the Week: ");
            //string theday = Console.ReadLine();

            //if (theday == 1)
            //{
            //    Console.WriteLine("Happy monday");
            //}
            //else if (theday == 2)
            //{
            //    Console.WriteLine("Day two of 7...");
            //}
            //else
            //{
            //    Console.WriteLine("Dude pick a day");
            //}
        }
    }
}
