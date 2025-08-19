namespace finaly_block
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // try
            // do the actual work

            // catch
            // exceptions handle

            // finally
            // memory free
            // or run code that always has to run

            string user_input = "";
            int thenumber = 0;

            Console.WriteLine("Enter a number between 1 and 10");
            user_input = Console.ReadLine();

            try
            {
                try
                {


                    // object create
                    try
                    {
                        thenumber = Convert.ToInt32(user_input);
                    }
                    finally
                    {
                        // need to free your obj
                        Console.WriteLine("This block will always execute");
                    }

                    // continue with code

                }
                catch (Exception e)
                {
                    Console.WriteLine("An exception occured: " + e.Message);
                }
            }
            finally
            {
                Console.WriteLine();
            }
        }
    }
}
