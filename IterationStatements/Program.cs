﻿using System;
using System.Collections.Generic;
// TODO: Follow the instructions provided in each comment below to complete the exercise.
// Use the example given to guide your implementation.

internal class Program
{
    private static void Main(string[] args)
    {
        //Create a List called "numbers" - DONE!
        List<int> numbers = new List<int>();  //DO NOT ERASE THIS! You will use this in the exercise.

        //-----START HERE------------------------------------------

        //TODO - Create a variable of type int and name it "num"
        var num = 0;
        //TODO - Initialize the variable with a value of 0



        //TODO - Create a do-while loop using the existing brackets as a template.

        do
        {
            num++;
            numbers.Add(num);
        } while (num < 100);
        // The existing brackets are placeholders for your loop code.
        // Inside this loop:
        // a) Increment "num" by 1
        // b) Then add "num" to the collection "numbers"
        //    Hint: Use "numbers.Add(num);" to add the current value of "num" to the list.




        //TODO - Create a while loop using the existing brackets as a template.
        //TODO - Continue the loop while "num" is less than 200
        // The existing brackets are placeholders for your loop code.
        // Inside this loop:
        // a) Increment "num" by 1
        // b) Then add "num" to the collection "numbers"
        //    Hint: You can copy how this was done in the do-while loop
        while (num < 200)
        {
            num++;
            numbers.Add(num);
            // Your code goes here
        }//TODO - Continue the loop while "num" is less than 200



        // This is to show the user that the numbers will start increasing on the console
        Console.WriteLine("Increase:");
        Console.WriteLine($"The first number in the list is {numbers[0]}");




        //TODO - Create a foreach loop using the existing brackets as a template.
        // The existing brackets are placeholders for your loop code.
        // Inside this loop, print each number in "numbers".

        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }



        Console.WriteLine("");
        Console.WriteLine("Decrease:");


        //TODO - Create a for loop using the existing brackets as a template.
        // The existing brackets are placeholders for your loop code.
        // This loop will print the numbers in reverse order - from 200 to 1.

        // a) In your initializer, set the value of "i" to 199
        // b) In your conditional, ensure that the loop continues as long as "i" is:
        //    - Less than or equal to the number of items in "numbers" (use "numbers.Count")
        //    - Greater than or equal to 0
        // c) Decrement "i" by 1 in each iteration
        for (int i = 199; i >= 0; i--)
        {
            //TODO - Inside the loop, place numbers[i] inside of the Console.WriteLine() method
            Console.WriteLine(numbers[i]); // Example placement of numbers[i] inside Console.WriteLine
        }
    }
}