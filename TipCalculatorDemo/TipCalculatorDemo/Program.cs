using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            string mealUserInput;
            string tipUserInput;
            double mealCalculatedAmount;
            double tipCalculatedAmount;
            double mealCalculatedTotalAmount;

            //create a header
            Console.WriteLine("+++++++++++++Tip Calculator++++++++++++++\n\n\n");

            //ask the user to input the cost of their meal
            Console.WriteLine("What was the cost of your meal?\n");

            //take user input value for the cost of the meal and store in mealUserInput variable
            mealUserInput = Console.ReadLine();

            //convert string to double data type
            //variable = Convert.ToDouble method (mealUserInput)
            mealCalculatedAmount = Convert.ToDouble(mealUserInput);

            //ask for user input for tip percentage
            Console.WriteLine("\nWhat percentage would you like to tip: (15% suggested)?");

            //take user input and store as a string variable
            tipUserInput = Console.ReadLine();

            //convert tip amount amount input to a double data type
            tipCalculatedAmount = Convert.ToDouble(tipUserInput);

            //write a mathmatical expression to determine tip amount
            tipCalculatedAmount = ((tipCalculatedAmount / 100) * mealCalculatedAmount);

            mealCalculatedTotalAmount = mealCalculatedAmount + tipCalculatedAmount;

            //mealCalculatedTotalAmount = Math.Round(mealCalculatedTotalAmount,2);
            //in order to round your numbers use the math.round method
            //Math.Round(value that you wish to round, decimal places)

            //display the total cost of our meal on screen
            Console.WriteLine("The total cost of your meal with tip is: $" + Math.Round(mealCalculatedTotalAmount,2) );
            Console.WriteLine("\nThe tip percentage input by the user was: " + tipUserInput + "%.");
            Console.WriteLine("\nThe calculated tip amount was: $" + Math.Round(tipCalculatedAmount, 2) + ".");


            Console.ReadLine();
        }
    }
}
