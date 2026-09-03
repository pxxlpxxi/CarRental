using CarRental.Interfaces;
using CarRental.Models.Cars;
using CarRental.Models.Receipts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Models
{
    internal class Rental
    {
        private Car _car;
        internal Car Car => _car;
        private Customer _customer;
        internal Customer Customer => _customer;
        private DateTime _startDate;
        internal DateTime StartDate => _startDate;
        private DateTime? _endDate;
        internal DateTime? EndDate => _endDate;
        private decimal _price;
        internal decimal Price => _price;
        private IReceiptSender _receiptSender;


        internal Rental(Car car, Customer customer, DateTime startDate, DateTime? endDate = null)
        {
            _car = car;
            _customer = customer;
            _startDate = startDate;
            _receiptSender = customer.ReceiptSender;
            _endDate = endDate;
        }

        internal decimal TotalPrice()
        {
            if (!_endDate.HasValue)
            {
                return 0;
            }

            int daysRented = (_endDate.Value - _startDate).Days;

            if (daysRented <= 0)
            {
                daysRented = 1;
            }

            return daysRented * _car.DailyPrice;
        }
        internal void ReturnCar(DateTime endDate, int newMileage)
        {
            _endDate = endDate;
            _car.Return(newMileage);
            _price = TotalPrice();

            Receipt receipt = CreateReceipt();

            _receiptSender.Send(receipt);
        }

        private Receipt CreateReceipt()
        {
            return new Receipt(this);
        }
    }
}
