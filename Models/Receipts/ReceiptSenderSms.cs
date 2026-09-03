using CarRental.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Models.Receipts
{
    internal class ReceiptSenderSms : IReceiptSender
    {
        public void Send(Receipt receipt)
        {
            Console.WriteLine($"Sending receipt to {receipt.Customer.PhoneNumber}");
        }
    }
}
