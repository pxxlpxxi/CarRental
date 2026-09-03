using CarRental.Models.Cars;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Models.Receipts
{
    internal class Receipt
    {
        private Car _car;
        internal Car Car => _car;
        private Customer _customer;
        internal Customer Customer => _customer;
        private DateTime _startDate;
        internal DateTime StartDate => _startDate;
        private DateTime _endDate;
        internal DateTime EndDate => _endDate;
        private decimal _price;
        internal decimal Price => _price;

        internal Receipt(Rental rental)
        {
            _car = rental.Car;
            _customer = rental.Customer;
            _startDate = rental.StartDate;
            _endDate = (DateTime)rental.EndDate;
            _price = rental.Price;
        }
    }
}
