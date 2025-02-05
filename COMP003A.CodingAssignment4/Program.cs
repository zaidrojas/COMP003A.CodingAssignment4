/*
 Author: Zaid Rojas
 Course: COMP-003A
 Faculty: Jonathan Cruz
 Purpose: Inventory management application with a minimum of 1
*/

using System.Reflection.Emit;

namespace COMP003A.CodingAssignment4
{
    internal class Program
    {


        static void Main(string[] args)
        {


            // Products in arrays
            string[] prod_array_name = new string[10];
            int[] prod_array_quantity = new int[10];
            // Products in list
            List<string> prod_list_name = new List<string>();
            List<int> prod_list_quantity = new List<int>();


            if (Introduction() == "Arrays")
            {
                Console.WriteLine("Array Stuff");
            }
            else
            {
                Console.WriteLine("List Stuff");
            }


            static string Introduction()
            {
                while (true)
                {
                    int storeage_choice;

                    // Introduction
                    Console.WriteLine("Welcome to the Inventory Management System!");
                    Console.WriteLine("Choose data storae tpye:");
                    Console.WriteLine("1. Arrays");
                    Console.WriteLine("2. Lists");
                    Console.Write("Enter your choice: ");
                    if (!int.TryParse(Console.ReadLine(), out storeage_choice))
                    {
                        Console.WriteLine($"**Invalid input. Please enter a valid number.**\n");
                        continue;
                    }

                    switch (storeage_choice)
                    {
                        case 1:
                            return "Arrays";
                        //break;
                        case 2:
                            return "Lists";
                        //break;
                        default:
                            Console.WriteLine("**Enter either numbers 1 or 2.**\n");
                            continue;
                    }
                }
            }


        }
    }
}
