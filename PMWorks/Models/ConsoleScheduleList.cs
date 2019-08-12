using System;
using System.Collections.Generic;

namespace PMWorks.Models
{
    public class ConsoleScheduleList
    {
        public String Issue { get; set; }
        public String IssueSource { get; set; }
        public String Reccurence { get; set; }
        public String Date { get; set; }
        public List<ConsoleScheduleList> ListOfConsoleMaintenanceSchedule()
        {
            List<ConsoleScheduleList> consoleScheduleList = new List<ConsoleScheduleList>()
{
new ConsoleScheduleList{Reccurence="Every first Monday Of Month",Issue="Beer Dispenser PM-QTR",IssueSource="Kitchen"},
new ConsoleScheduleList{Reccurence="Every 1st Monday of 1 quarter",Issue="Beer Dispenser PM-QTR",IssueSource="Kitchen"},
new ConsoleScheduleList{Reccurence="Every first Monday Of Month",Issue="Beer Dispenser PM-QTR",IssueSource="Kitchen"},
new ConsoleScheduleList{Reccurence="Every first Monday Of Month",Issue="Beer Dispenser PM-QTR",IssueSource="Kitchen"},
new ConsoleScheduleList{Reccurence="Every 1st Monday of 1 quarter",Issue="Beer Dispenser PM-QTR",IssueSource="Kitchen"},
new ConsoleScheduleList{Reccurence="Every first Monday Of Month",Issue="Beer Dispenser PM-QTR",IssueSource="Kitchen"},
new ConsoleScheduleList{Reccurence="Every 1st Monday of 1 quarter",Issue="Beer Dispenser PM-QTR",IssueSource="Kitchen"},
new ConsoleScheduleList{Reccurence="Every first Monday Of Month",Issue="Beer Dispenser PM-QTR",IssueSource="Kitchen"},
new ConsoleScheduleList{Reccurence="Every first Monday Of Month",Issue="Beer Dispenser PM-QTR",IssueSource="Kitchen"},
new ConsoleScheduleList{Reccurence="Every 1st Monday of 1 quarter",Issue="Beer Dispenser PM-QTR",IssueSource="Kitchen"},
new ConsoleScheduleList{Reccurence="Every first Monday Of Month",Issue="Beer Dispenser PM-QTR",IssueSource="Kitchen"}
};
            return consoleScheduleList;
        }
    }
}