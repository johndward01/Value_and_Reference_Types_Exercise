using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Value_Reference_Type_Exercise_01;

namespace Value_and_Reference_Types_Exercise_01
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double myDouble = .005;
            int myInteger = 10;
            string myString = "Hello World";

            Console.WriteLine("-------------VALUE TYPES-----------------");

            // TODO: Write out each of these to the Conosle like so:
            // Console.WriteLine($"Before: {yourVarible}");

            // TODO: Use the ChangeValueType() function to "change the value type" for each variable
            // Methods.ChangeValueType(yourVariable);

            Methods.AddSpaces(1);

            // Thought Experiment: What will the value of the original variable be after going through the ChangeValueType() method?
            // TODO: Double variable value = .005
            // TODO: Integer variable value = 10
            // TODO: String variable value = "Hello World"

            // Why:
            // Answer: Because these are Value Types their values are copied, therefore, when you write the original to the conosle none of them have changed!

            // TODO: Write out the original variable to the console after being changed by the ChangeValueType() function
            // Console.WriteLine($"Original: {yourVariable}");


            Methods.AddSpaces(1);


            // TODO: Use the 4 reference type variables that are already declared and initialized below
            StringBuilder sb = new StringBuilder("The starting string's value.");
            List<int> myList = new List<int>() { 1, 2, 3 };
            int[] myArray = new int[] { 4, 5, 6 };
            Dog myDogObject = new Dog { Name = "Lassy" };

            Console.WriteLine("-------------REFERENCE TYPES-----------------");

            // TODO: Write out each of these to the Conosle. Remember to use a loop for the list and array

            Methods.AddSpaces(1);

            Methods.AddSpaces(1);

            Methods.AddSpaces(1);

            Methods.AddSpaces(1);

            // TODO: Use the ChangeReferenceType() function to "change the reference type" for each variable

            // Thought Experiment: What will the value of the original variable be after going through the ChangeReferenceType() method?
            // TODO: StringBuilder variable value = The ending string's value.
            // TODO: List<int> variable values = 100200300
            // TODO: int[] variable values = 400500600
            // TODO: Dog object variable's name = A changed name

            // Why:
            // Answer: Because these are Reference Types their values are not copied, therefore, when you write the original to the conosle they will be changed!


            // TODO: Write out the original variables to the console after being changed by the ChangeReferenceType() function

            Methods.AddSpaces(1);

            Methods.AddSpaces(1);

            Methods.AddSpaces(1);
        }

       
    }
}
