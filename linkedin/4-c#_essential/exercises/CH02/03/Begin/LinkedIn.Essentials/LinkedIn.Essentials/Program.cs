// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;

//Employee e = new Employee {
//    FirstName = "Tony",
//    LastName = "Kieling",
//    EmployeeId = 75,
//    StartDate = new DateOnly(2021, 01, 01)
//};
Employee e = new Employee("tONY", "Kieling") {
    //FirstName = "Tony",
    //LastName = "Kieling",
    EmployeeId = 75,
    StartDate = new DateOnly(2021, 01, 01)
};
Console.WriteLine($"From {e.FirstName} {e.LastName} - {e.EmployeeId}, hello world. Start date is {e.StartDate} {e.Id}");
