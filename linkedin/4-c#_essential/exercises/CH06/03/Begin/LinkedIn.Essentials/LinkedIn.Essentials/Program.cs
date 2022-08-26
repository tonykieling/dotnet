// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;
using System.Diagnostics.CodeAnalysis;

string? input = "something";
int definiteInt;
int? age = null;
Nullable<int> age2 = null;

age = 5;
age ??= 12;
definiteInt = age ?? 17;

//definiteInt = age != null ? age.Value : 17;

//Console.WriteLine($"Age is: {definiteInt}");
//Console.WriteLine(PadAndTrim(input, 15, '0'));

//var shiftDay = GetShiftDays((DayOfWeek)17);
//Console.WriteLine(shiftDay);

static ShiftDays GetShiftDays(DayOfWeek day) => day switch
{
    DayOfWeek.Monday => ShiftDays.Monday,
    DayOfWeek.Tuesday => ShiftDays.Tuesday,
    DayOfWeek.Wednesday => ShiftDays.Wednesday,
    DayOfWeek.Thursday => ShiftDays.Thursday,
    DayOfWeek.Friday => ShiftDays.Friday,
    DayOfWeek.Saturday => ShiftDays.Saturday,
    DayOfWeek.Sunday => ShiftDays.Sunday,
    _ => throw new ArgumentException("Invalid day of week suppliied")

};
static string PadAndTrim([AllowNull]string input, int length, char padChar)
{
    if (input == null)
    {
        return String.Empty.PadLeft(length, padChar);
    }
    else if (input != null && input.Length <= length)
    {
        switch(padChar)
        {
            case ' ':
            case '|':
                return input.Trim().PadLeft(length, padChar);
            case '0':
            case '9':
                return input.Trim().PadRight(length, padChar);
            default:
                Console.WriteLine("No match found for pad character");
                break;
        }
        return input.Trim().PadLeft(length, padChar);
    }
    else
    {
        throw new ArgumentException("Input is longer than requested length");
    }
}

IPerson sw = new ShiftWorker { FirstName = "SWFstName", LastName = "SWLastName" };
IPerson mg = new Manager { FirstName = "ManagerFstName", LastName = "ManagerLastName" };
Console.WriteLine($"getDetails of {sw}: {GetPersonalDetails(sw)}");
//Console.WriteLine($"getDetails of {mg}: {GetPersonalDetails(mg)}");

static string GetPersonalDetails(IPerson p)
{
    /*
     *  The "is" statement is a test expression that returns a boolean value 
     *   indicating if a variable represents the named type. 
     *  The "as" statement converts an object to the specified type or null if the cast isn't valid.
     */
    //ShiftWorker? smv = p as ShiftWorker;
        // AS takes p and try to make it as ShiftWorker returning either a ShiftWorker or a NULL
    //if (smv != null)

    if (p is ShiftWorker smv) // => if p is a ShiftWorker, then create smv and assign p's value to smv
        // IS do the same PLUS creates a new variable and assign the value to it
        return ($"{smv.FirstName} {smv.LastName}");
    else if (p is Manager)
        return ($" Manager: {p.FirstName} {p.LastName}");
    return String.Empty;
}