﻿using System;

namespace CSharp8
{
    public class IndexRange
    {
        // https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#indices-and-ranges
        public void Sample()
        {
            var conferences = new[]
            {
                                           // index      from back
                "Letterkenny",             // 0          ^12
                "Dublin",                  // 1          ^11
                "Belfast",                 // 2          ^10     
                "Londenderry",             // 3          ^9
                "NTK",                     // 4          ^8
                "DevDayz",                 // 5          ^7
                "MSCommunity",             // 6          ^6
                "DevOpsConf",              // 7          ^5
                "AzureThursdays",          // 8          ^4
                "AdvancedTechnologyDays",  // 9          ^3
                "Thrive",                  // 10         ^2
                "SQLSaturday"              // 11         ^1
            };

            var lastConferenceOfTheYear = conferences[^1];

            var middleYearConferences = conferences[3..7]; // 3, 4, 5, 6

            var firstThreeConferences = conferences[..3];

            var lastThreeConferences = conferences[^3..];

            Index index = ^3;
            Range range = 4..7;

            var lastThreeConferences1 = conferences[range];
            var lastThreeConferences2 = conferences[index];

            string s = "0123456789";
            char lastChar = s[^1]; // lastChar = '9'
            string startFromIndex2 = s[2..]; // startFromIndex2 = "23456789"

            string substring1 = s[^10..]; // Replaces s.Substring(^10);
            string substring2 = s[2..8];   // Replaces s.Substring(2..8);
        }
    }
}
