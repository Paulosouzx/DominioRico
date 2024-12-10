namespace PaymentContext.Domain.Entities
{
    public abstract class Payment
    {

        public string Number { get; private set; }
        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public string Owner { get; private set; }
        public string Document { get; private set; }
        public string Address { get; private set; }
        public string Email { get; private set; }
        
        public Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string owner, string document, string address, string email)
        {
            //Substituo os tracos por nada e pego os primeiros 10 caracteres e coloco maiusculo
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0,10).ToUpper();
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Owner = owner;
            Document = document;
            Address = address;
            Email = email;
        }
    }
}