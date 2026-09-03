using CarRental.Models.Receipts;

namespace CarRental.Interfaces
{
    internal interface IReceiptSender
    {
       void Send(Receipt receipt);
    }
}
