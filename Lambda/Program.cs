namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Choose an option:\n 1.First Name  \n 2.Last name \n 3.Enter email \n 4.Enter the number \n 5.Enter the password");
            int result = Convert.ToInt32(Console.ReadLine());

            switch (result)
            {
                case 1:
                    Console.WriteLine("Enter your first name ");
                    string firstname = Console.ReadLine();
                    UC1.CheckFirstName(firstname);
                    break;
                case 2:
                    Console.WriteLine("Enter your last name");
                   string lastname = Console.ReadLine();
                    UC1.CheckLastName(lastname);
                    break;
                case 3:
                    Console.WriteLine("Enter the mail");
                   string email = Console.ReadLine();
                    UC1.CheckEmail(email);
                    break;
                case 4:
                    Console.WriteLine("Enter the phone number");
                   string mobileNumber1 = Console.ReadLine();
                    UC1.CheckMobileNumber(mobileNumber1);
                    break;
                case 5:
                    Console.WriteLine("Enter the password");
                   string password = Console.ReadLine();
                    UC1.CheckPassword(password);
                    break;


            }
        }
    }
}
