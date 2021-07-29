using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Part One - Multiplication // 

            // Create a console application that, given a comma separated list of
            // strings, prints the result of multiplying the values together.

            //Console.WriteLine("Choose to either square '^', multiply '*', add '+', or divide '/',");
            //Console.WriteLine("Please enter three numbers, seperated by a comma.");

            //var userInput = Console.ReadLine();

            //var programResponse = Console.ReadLine();

            //var multiply = userInput.Split(",");

            //Console.WriteLine(int.Parse(multiply[0]) * int.Parse(multiply[1]) * int.Parse(multiply[2]));

            // END //

            // Add an option asking the user whether to multiply (previous case) or
            // square the numbers being passed in. If the user chooses square, each
            // number in the list should be multiplied by itself and then returned as a comma separated list.


            // Asks user to pick which operator they would like to use // 
            // Declares variable of 'programResponse' to the user's input 
            Console.WriteLine("Choose to either square '^', multiply '*', add '+', divide '/', or 'avg'");
            var programResponse = Console.ReadLine();

            // Asks users to enter three numbers, seperated by a comma // 
            // Declares 'userInput' to the next input of the user
            Console.WriteLine("Please enter three numbers, seperated by a comma.");
            var userInput = Console.ReadLine();


            // creates a switch case that is passed int he value the user chooses // 

            switch (programResponse)

            // Declares case for possible user input // 
            // int.Parse method converts the string representation
            // of a number to its 32 - bit signed integer equivalent //
            // double - used to define numeric variables holding numbers with decimal points //
            {
                case "^":
                    var squared = userInput.Split(",");
                    Console.WriteLine(int.Parse(squared[0]) * int.Parse(squared[0]) + "," +
                    int.Parse(squared[1]) * int.Parse(squared[1]) + "," +
                    int.Parse(squared[2]) * int.Parse(squared[2]));
                    break;
                case "*":
                    var multiply = userInput.Split(",");  
                    Console.WriteLine(int.Parse(multiply[0]) * int.Parse(multiply[1]) * int.Parse(multiply[3]));
                    break;
                case "/":
                    var divide = userInput.Split(",");
                    var divisionOne = (double)int.Parse(divide[0]) / int.Parse(divide[1]);
                    var divisionTwo = (double)int.Parse(divide[2]);
                    Console.WriteLine((double)divisionOne / (double)divisionTwo);
                    break;
                case "+":
                    var addition = userInput.Split(",");
                    Console.WriteLine(int.Parse(addition[0]) + int.Parse(addition[1]) + int.Parse(addition[2]));
                    break;
                case "avg":
                    var average = userInput.Split(",");
                    var sum = int.Parse(average[0]) + int.Parse(average[1]) + int.Parse(average[2]);
                    Console.WriteLine((double)sum / 3);
                    break;

            }
        }
    }
}
