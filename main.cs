// Created by: Timothy Manwell
// Created on: Dec 2022
//
// This program Calculates Pi
using System;

class Program
{
    public static void Main(string[] args)
    {
        var counter = 0.00;
        int timesThroughLoop;
        var piAnswer = 0.00;

        Console.Write("Enter a positive or negative integer to calculate Pi. The higher the integer, the more acurate the result: ");
        timesThroughLoop = Convert.ToInt32(Console.ReadLine());
        while (counter < timesThroughLoop)
        {
            piAnswer = piAnswer + (4 / (1 + 2 * counter)) * Math.Pow(-1, counter);
            counter++;
        }
        Console.Write(piAnswer);
        Console.Write("\nDone");
    }
}