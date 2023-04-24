// Assume we have a List<Employee> called employees
using ConsoleApp2;

var employees = new List<Employee>
{
    new Employee { EmployeeId = 1, Name = "John Smith", JobRole = JobRole.Developer, DateJoined = new DateTime(2022, 1, 1), City = "New York", RemoteWorking = true },
    new Employee { EmployeeId = 2, Name = "Jane Doe", JobRole = JobRole.SrDeveloper, DateJoined = new DateTime(2021, 4, 1), City = "San Francisco", RemoteWorking = false },
    new Employee { EmployeeId = 3, Name = "Bob Johnson", JobRole = JobRole.Architect, DateJoined = new DateTime(2020, 10, 1), City = "Chicago", RemoteWorking = true },
    new Employee { EmployeeId = 4, Name = "Mary Lee", JobRole = JobRole.Manager, DateJoined = new DateTime(2019, 7, 1), City = "Houston", RemoteWorking = false },
};



var currentDate = DateTime.Today;

var lessThanOneYear = employees.Where(e => (currentDate - e.DateJoined).TotalDays <= 365);
var oneToTwoYears = employees.Where(e => (currentDate - e.DateJoined).TotalDays > 365 && (currentDate - e.DateJoined).TotalDays <= 730);
var moreThanTwoYears = employees.Where(e => (currentDate - e.DateJoined).TotalDays > 730);

var lessThanOneYearRemote = lessThanOneYear.Where(e => e.RemoteWorking == true);
var lessThanOneYearOffice = lessThanOneYear.Where(e => e.RemoteWorking == false);

var oneToTwoYearsRemote = oneToTwoYears.Where(e => e.RemoteWorking == true);
var oneToTwoYearsOffice = oneToTwoYears.Where(e => e.RemoteWorking == false);

var moreThanTwoYearsRemote = moreThanTwoYears.Where(e => e.RemoteWorking == true);
var moreThanTwoYearsOffice = moreThanTwoYears.Where(e => e.RemoteWorking == false);

var orderedReport = lessThanOneYearRemote
    .Concat(lessThanOneYearOffice)
    .Concat(oneToTwoYearsRemote)
    .Concat(oneToTwoYearsOffice)
    .Concat(moreThanTwoYearsRemote)
    .Concat(moreThanTwoYearsOffice)
    .OrderByDescending(e => (currentDate - e.DateJoined).TotalDays);


foreach (var employee in orderedReport)
{
    Console.WriteLine($"Employee Id: {employee.EmployeeId}, Name: {employee.Name}, Job Role: {employee.JobRole}, Date Joined: {employee.DateJoined.ToShortDateString()}, City: {employee.City}, Remote Working: {(employee.RemoteWorking ? "Yes" : "No")}");
}



// Now you can iterate over the orderedReport to print out the results
