﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs
{
   /* class ArrayMaxResult
    {
        static void Main(string[] args)
        {

            int Min = 1;
            int Max = 10;
            int[] numbers = {1, 2, 3, 4, 5};


            Random randNum = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = randNum.Next(Min, Max);
            }

            bool correct = false;

            do
            {
                Console.Write("Please pick 1 number from the selection of " + string.Join(",", numbers) + " : ");
                Console.ReadLine();
            } while (correct);
            {


            var m = from x in numbers
                    group x by x into y
                    select y;

            foreach(var arrEle in m)
            {
                Console.WriteLine(arrEle.Key + "\t" + arrEle.Sum() + "\t\t\t" + arrEle.Count());
            }
            Console.WriteLine();
                Console.ReadLine();
            }
          
        
        }
    }
   */

    class LeapYearCalendar
    {
                static void Main(string[] args)
            {
            DateTime myValue = DateTime.Now;
            Console.WriteLine( "Here is the current year: " + myValue.ToShortDateString()); //month,day,year

            bool correct = false;
     

            do{

            Console.WriteLine("Enter a year to find out if it is a leap year!: ");
            Console.ReadLine();

            }while(correct);
            {
            for (int year = 1990; year <= 2020; year++)
              {
            if (DateTime.IsLeapYear(year))
         {
            Console.WriteLine("{0} is a leap year.", year);
            DateTime leapDay = new DateTime(year, 2, 29);
            DateTime nextYear = leapDay.AddYears(1);
            Console.WriteLine("   One year from {0} is {1}.",
                              leapDay.ToString("d"),
                              nextYear.ToString("d"));
         }
      }
            }
            Console.ReadLine();

            }
}







}