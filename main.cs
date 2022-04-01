// Created by: Kenny Le
// Created on: Mar 2022
//
// This program finds the volume of a pyramid

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function calculates the area of a Trapezoid
        double lengthOfPyramid;
        double widthOfPyramid;
        double heightOfPrayamid;
        double volume;

        // input
        Console.WriteLine("This program calculates the volume of a pyramid.");
        Console.WriteLine("");
        Console.WriteLine("The formula is: v = (l × w × h) / 3");
        Console.WriteLine("");
        Console.WriteLine("Please enter the measurements (cm).");

        Console.WriteLine("");
        Console.Write("Input the measurement for the length: ");
        lengthOfPyramid = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input the measurement for the width: ");
        widthOfPyramid = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input the measurement for the height: ");
        heightOfPrayamid = Convert.ToDouble(Console.ReadLine());

        // process
        Console.WriteLine("");
        volume = (lengthOfPyramid * widthOfPyramid * heightOfPrayamid) / 3;

        // output
        Console.WriteLine("The area of the trapezoid is: " + volume.ToString("0.00") + " " + "cm³.");

        Console.WriteLine("\nDone.");
    }
}