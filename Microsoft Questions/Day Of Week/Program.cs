using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_Of_Week
{
    class Program
    {
        /**************************
         * Given current day as day of the week and an integer K, the task is to find the day of the week after K days.

Example 1:
Input:
day = “Monday”

K = 3

Output: Thursday
Example 2:
Input:
day = “Tuesday”

K = 101

Output: Friday
         * 
         * Sunday -0
         * Monday -2 
         * Tue-3
         * Wed-4
         * Thurs-5
         * Fri-6
         * Sat-7
         * Sun-8
         * 
         * 
         * 
         * 
         * 
         * ***********************/
        static void Main(string[] args)
        {
            dayOfWeek("Tuesday", 101);
        }
        public static String dayOfWeek(String day, int k)
        {
            var week = new List<string>
            {
               "Sunday",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
            };
            int index = week.IndexOf(day);
            int ret_index = (index + k) % 7;
            string retval= week[ret_index];
            return retval;
           
            
        }
    }
}
