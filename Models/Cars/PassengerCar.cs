using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Models.Cars
{
    internal class PassengerCar : Car
    {
        private int _numberOfSeats;
        internal int NumberOfSeats => _numberOfSeats;
        internal PassengerCar(string registrationNumber, string brand, string model, int mileage, decimal dailyPrice, int numberOfSeats)
            : base(registrationNumber, brand, model, mileage, dailyPrice)
        {
            _numberOfSeats = numberOfSeats;
        }
    

    }
}
