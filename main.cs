using System;  
using static System.Console;
class Program
{
    static void Main()
    {
        const double CENTIMETERS_PER_INCH = 2.54; 
        Write("Enter the number of inches: ");
        double inches = Convert.ToDouble(ReadLine());
        WriteLine("{0} inches is {1} centimeters", inches, inches * CENTIMETERS_PER_INCH);
    }
}