using CarRental.Interfaces;
using CarRental.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Models.Receipts
{
    internal class PrintedReceipt : IReceiptSender
    {
        internal PrintedReceipt() { }

        void IReceiptSender.Send(Receipt receipt)
        {
            int width = 45;
            string header = Company.GetCompany().Name;
            string line = new string('─', width);

            string car1 = $"Car: ";
            string car2 = $"{receipt.Car.Brand} {receipt.Car.Model}".PadLeft(width - car1.Length);

            string registration1 = $"Registration: ";
            string registration2 = $"{receipt.Car.RegistrationNumber}".PadLeft(width-registration1.Length);

            string start1 = $"Start: ";
            string start2 = $"{receipt.StartDate}".PadLeft(width- start1.Length);

            string end1 = "End: ";
            string end2 = $"{receipt.EndDate}".PadLeft(width-end1.Length);

            string price1 = $"Price: ";
            string price2 = $"{receipt.Price} kr.".PadLeft(width-price1.Length);

            Console.WriteLine(line);
            Console.WriteLine(header.PadLeft((width + header.Length) / 2));
            Console.WriteLine(line);

            Console.WriteLine(car1 + car2);
            Console.WriteLine(registration1 + registration2);
            Console.WriteLine(start1 + start2);
            Console.WriteLine(end1 + end2 + "\n");
            Console.WriteLine(price1 + price2);

            Console.WriteLine(line);
        }
    }
}

