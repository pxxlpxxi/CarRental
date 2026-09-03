using CarRental.Models;
using CarRental.Models.Cars;
using System.Runtime.ConstrainedExecution;

Company company = Company.GetCompany();

company.AddCar(new PassengerCar("AB12345", "Toyota", "Corolla", 50000, 500, 5));

company.AddCustomer(new("Alice", "12345678", "8272639", null, "alice@example.com"));

Rental rental = company.RentCar(company.AvailableCars[0], company.AllCustomers[0]);

Console.WriteLine(company.AllCars[0].IsAvailable);

Console.WriteLine("\n\n");
company.ReturnCar(company.AllCars[0], 5200);
Console.WriteLine("\n\n");


Console.WriteLine(company.AllCars[0].IsAvailable);