using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Models.Cars
{
    internal abstract class Car
    {
        private string _registrationNumber;
        internal string RegistrationNumber => _registrationNumber;
        private string _brand;
        internal string Brand => _brand;
        private string _model;
        internal string Model => _model;
        private int _mileage;
        internal int Mileage => _mileage;
        private decimal _dailyPrice;
        internal decimal DailyPrice => _dailyPrice;
        private bool _isAvailable;
        internal bool IsAvailable => _isAvailable;

        protected Car(string registrationNumber, string brand, string model, int mileage, decimal dailyPrice)
        {
            _registrationNumber = registrationNumber;
            _brand = brand;
            _model = model;
            _mileage = mileage;
            _dailyPrice = dailyPrice;
            _isAvailable = true;
        }
        internal void Rent() {
            _isAvailable = false;
        }
        internal void Return(int newMileage) {
            _isAvailable = true;
            _mileage = newMileage;
        }
    }
}
