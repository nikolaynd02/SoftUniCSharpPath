﻿using System;

namespace P01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string reversed = string.Empty;
                for(int i = input.Length - 1; i >= 0;i--)
                {
                    reversed += input[i];
                }

                Console.WriteLine($"{input} = {reversed}");
            }
        }
    }
}
