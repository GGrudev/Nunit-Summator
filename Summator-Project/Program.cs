﻿using System;

namespace Summator_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Summator.Sum(new int[] { 1, 2, 3, 4, 5, 6 });
                if(result == 21)
            {
                Console.WriteLine("Test pass");
            }
            else
            {
                Console.WriteLine("Test fail");
            }


        }
    }
}
