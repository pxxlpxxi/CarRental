using CarRental.Interfaces;
using CarRental.Models.Receipts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarRental.Models
{
    internal class Customer
    {
        private string _name;
        internal string Name => _name;
        private string _licenseNumber;
        internal string LicenseNumber => _licenseNumber;
        private string _phoneNumber;
        private string? _email;
        internal string? Email => _email;
        internal string PhoneNumber => _phoneNumber;

        //Mangler opdatering i diagram:
        private IReceiptSender _receiptSender;
        internal IReceiptSender ReceiptSender => _receiptSender;


        internal Customer(string name, string licenseNumber, string phoneNumber, IReceiptSender? receiptSender = null, string? email = null)
        {
            _name = name;
            _licenseNumber = licenseNumber;
            _phoneNumber = phoneNumber;
            _receiptSender = receiptSender != null
                ? receiptSender
                : new PrintedReceipt();
            _email = email;
        }
    }
}
