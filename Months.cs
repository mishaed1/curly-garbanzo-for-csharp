using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    internal class Months
    {
        readonly string[] months = ["January", "February", "March","April", "May",
            "June", "July", "August", "September","October", "November", "December"];

        public string PrintMonthTitle( int monthNumber )
        {
            string monthName = months[ monthNumber - 1 ];
            return monthName;
        }

        public void CalculatedNumberOfMonths( int monthIndexStart, int monthIndexEnd)
        {
            monthIndexStart -= 1;
            monthIndexEnd -= 1;
             int result = (monthIndexEnd) - (monthIndexStart);
            Console.WriteLine($"There are {result} months between " +
                $"{months[monthIndexStart]}" +
                $" and {months[monthIndexEnd]}");
        }
    }
}
