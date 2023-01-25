using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Exercise 71
//written by Muna Shabab
//date: 

namespace _71_Muna_Shabab
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //explain the program to the user
            Console.WriteLine("This program will accept 5 integer inputs and determine the number of positive," +
                " negative, and zero integers entered");

            //get the integers and assign them to the variables keeping count of positives, negatives, and zeros
            int numberOfPositive = 0, numberOfnegative = 0, numberOfZero = 0;

            Console.WriteLine("Please enter the first integer:");
            string userInput = Console.ReadLine();
            int integer1 = GetValidInteger(userInput);
            SortNumber(integer1);

            Console.WriteLine("Please enter the second integer:");
            userInput = Console.ReadLine();
            int integer2 = GetValidInteger(userInput);
            SortNumber(integer2);
            
            Console.WriteLine("Please enter the third integer:");
            userInput = Console.ReadLine();
            int integer3 = GetValidInteger(userInput);
            SortNumber(integer3);


            Console.WriteLine("Please enter the forth integer:");
            userInput = Console.ReadLine();
            int integer4 = GetValidInteger(userInput);
            SortNumber(integer4);

            Console.WriteLine("Please enter the fifth integer:");
            userInput = Console.ReadLine();
            int integer5 = GetValidInteger(userInput);
            SortNumber(integer5);


            //display the results
            Console.WriteLine($"{numberOfnegative} negative integers entered, {numberOfPositive} " +
                $"positive integers entered," +
                $" {numberOfZero} zeros entered");
            Console.ReadLine();

            //a function to determine the relative value of a number to zero
            void SortNumber(int num)
            {
                if (num > 0)
                {
                    numberOfPositive += 1;
                }
                else if (num < 0)
                {
                    numberOfnegative += 1;
                }
                else
                {
                    numberOfZero += 1;
                }

            }
           
        }

        //a function to get valid integer input
        static int GetValidInteger(string input)
        {
            int num;
            while(!int.TryParse(input, out num))
            {
                Console.WriteLine( input + " is not a valid integer, please enter an integer:");
                input = Console.ReadLine();
            }

            return num;
        }

       

            
    }
}
