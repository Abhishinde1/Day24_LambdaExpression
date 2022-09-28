﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lambda
{
    public class UC1
    {
        public static Func<string, string> CheckFirstName = (firstName) =>
        {
            string pattern = "(^[^a-z][A-z]{1}[a-z]{2,}$)";
            if (Regex.IsMatch(firstName, pattern))
            {
                Console.WriteLine("entered name is valid");
                return firstName;
            }
            else
            {
                Console.WriteLine("Entered name is Invalid\n please give first character in capital and minimum 3 characters name");
            }
            return firstName;
        };
        public static Func<string, string> CheckLastName = (lastName) =>
        {
            string pattern = "^[A-Z][a-z]{3,}$";
            if (Regex.IsMatch(lastName, pattern))
            {
                Console.WriteLine("enter name is valid");
                return lastName;
            }
            else
            {
                Console.WriteLine("Entered name is Invalid\n Please enter first character of your lastname in capital and minimum 3 characters name");
            }
            return lastName;
        };
    }
}
