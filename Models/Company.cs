using CarRental.Models.Cars;
using CarRental.Models.Receipts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Models
{
    internal class Company
    {
        private static Company _company = new();
        internal static Company GetCompany() => _company;
        private string _name = "Sjælland Bil";
        internal string Name => _name;
        private List<Car> _allCars = new List<Car>();
        internal IReadOnlyList<Car> AllCars => _allCars;
        private List<Car> _availableCars = new List<Car>();
        internal IReadOnlyList<Car> AvailableCars => _availableCars;
        private List<Rental> _allRentals = new List<Rental>();
        internal IReadOnlyList<Rental> AllRentals => _allRentals;
        private List<Customer> _allCustomers = new List<Customer>();
        internal IReadOnlyList<Customer> AllCustomers => _allCustomers;

        private Company()
        {

        }
        internal void AddCar(Car car)
        {
            _allCars.Add(car);
            _availableCars.Add(car);
        }

        public void AddCustomer(Customer customer)
        {
            _allCustomers.Add(customer);
        }

        public Rental RentCar(Car car, Customer customer)
        {
            if (!_allCars.Contains(car))
                throw new ArgumentException("Bilen findes ikke.");

            if (!_allCustomers.Contains(customer))
                throw new ArgumentException("Kunden findes ikke i systemet.");

            if (!_availableCars.Contains(car))
                throw new InvalidOperationException("Bilen er ikke ledig.");

            Rental rental = new Rental(
                car,
                customer,
                DateTime.Now                
            );

            _allRentals.Add(rental);
            _availableCars.Remove(car);
            car.Rent();

            return rental;
        }

        public void ReturnCar(Car car, int newMileage)
        {

            Rental? activeRental = _allRentals
                .Find(r => r.Car == car && !r.EndDate.HasValue);

            if (activeRental == null)
                throw new InvalidOperationException(
                    "Bilen har er ikke udlejet."
                );

            activeRental.ReturnCar(DateTime.Now, newMileage);
           
        }
    }
}
