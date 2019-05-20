using System;
using System.Reflection.Metadata.Ecma335;

namespace CSharp8
{
    public class SwitchExpressions
    {
        public enum Conference
        {
            Letterkenny,
            Londenderry,
            Belfast,
            Limerik,
            NTK,
            DevDayz,
            MSCommunity,
            DevOpsConf,
            Office365Bootcamp,
            AdvancedTechnologyDays,
            Thrive,
            SqlSaturday
        };

        public static string GetConferenceMonth(Conference conference) =>
            conference switch
            {
                Conference.Letterkenny => "March",
                Conference.Londenderry => "April",
                Conference.Belfast => "May",
                Conference.Limerik => "May",
                Conference.NTK => "May",
                Conference.DevDayz => "August",
                Conference.MSCommunity => "September",
                Conference.DevOpsConf => "October",
                Conference.Office365Bootcamp => "October",
                Conference.Thrive => "November",
                Conference.AdvancedTechnologyDays => "December",
                Conference.SqlSaturday => "December",
                _ => throw new ArgumentException("Invalid conference")
            };

        public static string GetConferenceMonthOld(Conference conference)
        {
            switch (conference)
            {
                case Conference.Letterkenny:
                    return "March";
                case Conference.Londenderry:
                    return "April";
                case Conference.Belfast:
                case Conference.Limerik:
                case Conference.NTK:
                    return "May";
                case Conference.DevDayz:
                    return "August";
                case Conference.MSCommunity:
                    return "September";
                case Conference.DevOpsConf:
                case Conference.Office365Bootcamp:
                    return "October";
                case Conference.Thrive:
                    return "November";
                case Conference.AdvancedTechnologyDays:
                case Conference.SqlSaturday:
                    return "December";
                default:
                    throw new ArgumentException("Invalid conference");
            }
        }
    }
}
