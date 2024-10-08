﻿using System;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dates & TimesValue
            var dateTime = new DateTime(2025, 1, 1);
            var now = DateTime.Now; //Current
            var today = DateTime.Today;

            Console.WriteLine("Hour:" + now.Hour);
            Console.WriteLine("Minute:" + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterdat = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            //---------------------------------------------------------------//
            //TimeSpan Creating
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1); // Represent 1 hour

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            //Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            //Add
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString
            Console.WriteLine("ToString: " + timeSpan.ToString());

            //Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));


        }
    }
}