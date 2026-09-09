/* 
Difference between Two Months – Example 
Let’s take a look at the following task: we have to write a program which, by 
given two numbers, that are between 1 and 12 (so to correspond to a 
particular month) prints the count of months between these months. The 
message that must be printed to the console must be "There is X months 
period from Y to Z.", where X is the count of the months, that we must 
calculate, and Y and Z, are respectively the names of the months that mark 
start and end of the period. 
By reading carefully the task we will try to divide it into subtasks, that can be 
more easily solved, and then by combining them to get the whole solution. 
We can see that we have to solve the following subtasks: - To enter the months numbers that mark beginning and end of the 
period. - To calculate the period between the input months. - To print the message. - In the message instead of the numbers we entered, for beginning and 
end of the period, we must write their corresponding month names in 
English. 
A possible solution of the given task is shown below: 
*/

using System; 
 
class Months 
{ 
 static string GetMonthName(int month) 
 { 
  string monthName; 
  switch (month) 
  { 
    case 1: 
      monthName = "January"; 
      break; 
    case 2: 
     monthName = "February"; 
     break; 
    case 3: 
     monthName = "March"; 
     break; 
    case 4: 
     monthName = "April"; 
     break; 
    case 5: 
     monthName = "May"; 
     break; 
    case 6: 
     monthName = "June"; 
     break; 
    case 7: 
     monthName = "July"; 
     break; 
    case 8: 
     monthName = "August"; 
     break; 
    case 9: 
     monthName = "September"; 
     break; 
    case 10: 
     monthName = "October"; 
     break; 
    case 11: 
     monthName = "November"; 
     break; 
Chapter 9. Methods  341 
    case 12: 
     monthName = "December"; 
     break; 
    default: 
     Console.WriteLine("Invalid month!"); 
     return null; 
  } 
  return monthName; 
 } 
 
 static void SayPeriod(int startMonth, int endMonth) 
 { 
  int period = endMonth - startMonth; 
  if (period < 0) 
  { 
   // Fix negative distance 
   period = period + 12; 
  } 
  Console.WriteLine( 
   "There is {0} months period from {1} to {2}.", 
   period, GetMonthName(startMonth), 
   GetMonthName(endMonth)); 
 } 
 
 static void Main() 
 { 
  Console.Write("First month (1-12): "); 
  int firstMonth = int.Parse(Console.ReadLine()); 
 
  Console.Write("Second month (1-12): "); 
  int secondMonth = int.Parse(Console.ReadLine()); 
 
  SayPeriod(firstMonth, secondMonth); 
 } 
} 
