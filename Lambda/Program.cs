namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Choose an option:\n 1.First Name ");
            int result = Convert.ToInt32(Console.ReadLine());

            switch (result)
            {
                case 1:
                    Console.WriteLine("Enter your first name ");
                    string firstname = Console.ReadLine();
                    UC1.CheckFirstName(firstname);
                    break;
            }
        }
    }
}
