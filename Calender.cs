﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment;

public class Calender
{
    public enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public void PrintWeekdays()
    {
        Console.WriteLine("The days of week:");

        foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
        {
            if (day >= DaysOfWeek.Monday && day <= DaysOfWeek.Friday)
            {
                Console.WriteLine(day);
            }
        }
    }
}
