using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abad_LAB1_EX
{
    internal class Program
    {
        static void Main(string[] args)

        {  //CostumerName.
            Console.WriteLine("Hi! Please enter your name; ");
            string name = Console.ReadLine();

            Console.WriteLine("\n \nWelcome to our Self-Service Store:), "+ name +"!!");
           
            //no. of apple that want to purchase.
            Console.Write("\nPlease, place your apple piece(s): ");
            int pieces;
            pieces = Convert.ToInt32(Console.ReadLine());
            

            // price per piece.
            Console.Write("Put in the cost of your " + pieces + " apple(s) per piece: ");
       float pricePerpiece ;
            pricePerpiece = float.Parse(Console.ReadLine());

         //calculate the total price.
       float TotalPrice = pieces * pricePerpiece;
            Console.WriteLine($"\nThe total price for your apple(s) is: {TotalPrice:F2} ");
            Console.WriteLine($"You need to pay exactly {TotalPrice:F2} " + " for your apple(s).");
           
            //the total price with decimal.
            Console.WriteLine($"\n\nThe initial price's value is: {TotalPrice:F2}");

            int FinalValue = (int)TotalPrice;
            //the total cost after conversion of float to int.
            Console.WriteLine("The converted price's final value is: " + FinalValue);
            Console.WriteLine("\nThank you for choosing our product.\nWe appreciate your trust and\nwe’ll do our best to meet your expectations.");
            Console.Write("\n \nPress any key to exit ..");
            
            Console.ReadLine();

            


        }
    }
}
