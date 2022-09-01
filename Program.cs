﻿using System;

namespace CabinvoiceGenerator
{
    /// <summary>
    /// Here,We check the cab invoice generator.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(":::::::Welcome To Cab Invoice Generator Program::::::::");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);

            double fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine(fare);
        }
    }
}
