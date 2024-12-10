namespace PaymentContext.Domain.Entities;

public class PayPalPayment(
    DateTime paidDate,
    DateTime expireDate,
    decimal total,
    decimal totalPaid,
    string owner,
    string document,
    string address,
    string email,
    string transactionCode)
    : Payment(paidDate, expireDate, total, totalPaid, owner, document, address, email)
{
    public string TransactionCode { get; set; } = transactionCode;
}