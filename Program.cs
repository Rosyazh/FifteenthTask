﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

/*
Develop a console application for validating inputted email adresses, URLs, file paths using regular expressions.
 */

namespace FifteenthTask
{
    class Program
    {
        static void Email()
        {
            Console.WriteLine("Enter email: ");
            string email = Convert.ToString(Console.ReadLine());
            if (Regex.IsMatch(email, @"^[a-zA-Z0-9._%-]+@[a-zA-Z0-9._%-]+\.[a-zA-Z]{2,4}\s*$", RegexOptions.IgnoreCase))
            {
                Console.WriteLine("Validated Email.");
            }
            else
            {
                Console.WriteLine("Invalidated email.");
            }
        }

        static void URL()
        {
            Console.WriteLine("Enter URL: ");
            string url = Convert.ToString(Console.ReadLine());
            if (Regex.IsMatch(url, @"^http\://[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(/\S*)?$", RegexOptions.IgnoreCase))
            {
                Console.WriteLine("Validated URL.");
            }
            else
            {
                Console.WriteLine("Invalidated URL.");
            }
        }

        static void FilePath()
        {
            Console.WriteLine("Enter file path: ");
            string filePath = Convert.ToString(Console.ReadLine());
            if (Regex.IsMatch(filePath, @"^(([a-zA-Z]\:)|\\)(\\|(\\[^/:*?<>""|]*)+)$", RegexOptions.IgnoreCase))
            {
                Console.WriteLine("Validated file path.");
            }
            else
            {
                Console.WriteLine("Invalidated file path.");
            }
        }

        static void Main(string[] args)
        {
            Email();
            URL();
            FilePath();
        }
    }
}
