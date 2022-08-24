// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;

Employee e = new Employee("Matt", "Milner", 75)
{
    StartDate = new DateOnly(2021, 1, 15)
};

Console.WriteLine($"From {e.FirstName}  id {e.Id}, hello world");

//PremiereCustomer pCustomer = new PremiereCustomer(8);
PremiereCustomer pCustomer = new PremiereCustomer { CustomerLevel = 8 };
pCustomer.FirstName = "FName";
pCustomer.LastName = "last";
//pCustomer.CustomerLevel = 2;
Console.WriteLine($"Customer: {pCustomer.FirstName} {pCustomer.LastName}, level # {pCustomer.CustomerLevel}");

Manager m = new Manager("The", "boss");
//m.NumberOfDirectReports(10);
m.SetReports(10);
Console.WriteLine($"Manager {m.FirstName} {m.LastName} got {m.NumberOfDirectReports} reports.");