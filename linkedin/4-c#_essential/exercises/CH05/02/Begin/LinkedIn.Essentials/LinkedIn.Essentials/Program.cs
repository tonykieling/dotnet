// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;

ShiftWorker d = new ShiftWorker() { FirstName = "Dynamic", 
    LastName = "Worker" };
//d.DaysAvailable = ShiftDays.Wednesday | ShiftDays.Tuesday;
//d.DaysAvailable = ShiftDays.Saturday | ShiftDays.Sunday;
//d.DaysAvailable = ShiftDays.Monday | ShiftDays.Tuesday | ShiftDays.Wednesday | ShiftDays.Thursday | ShiftDays.Friday;
d.DaysAvailable = ShiftDays.Weekday | ShiftDays.Weekend;



Console.WriteLine(d.DaysAvailable);

var day = DayOfWeek.Monday;
//Console.WriteLine(day);
var shiftDay = ShiftDays.Tuesday;
//Console.WriteLine((int)shiftDay);
