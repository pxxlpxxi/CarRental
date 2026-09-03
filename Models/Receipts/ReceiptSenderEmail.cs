using CarRental.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Models.Receipts
{
    internal class ReceiptSenderEmail : IReceiptSender
    {
        public ReceiptSenderEmail()
        {
        }


        void IReceiptSender.Send(Receipt receipt)
        {
            Console.WriteLine($"Sending receipt to {receipt.Customer.Email}");
        }
    }
}
