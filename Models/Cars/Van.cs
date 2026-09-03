using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Models.Cars
{
    internal class Van : Car
    {
        private int _loadCapacity;
        internal int LoadCapacity => _loadCapacity;

        internal Van(string registrationNumber, string brand, string model, int mileage, decimal dailyPrice, int loadCapacity)
            : base(registrationNumber, brand, model, mileage, dailyPrice)
        {
            _loadCapacity = loadCapacity;
        }

    }
}
