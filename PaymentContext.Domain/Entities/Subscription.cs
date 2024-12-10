using System;

namespace PaymentContext.Domain.Entities
{
  public class Subscription
  {
    //Nao sera possivel fazer uma nova instancia depois que ela for iniciada no construtor.
    private readonly IList<Payment> _payments;

    public DateTime CreateDate { get; private set; }
    public DateTime LastUpdateDate { get; private set; }
    public DateTime? ExpireDate { get; private set; }
    public bool Active { get; set; }
    public IReadOnlyCollection<Payment> Payments { get; private set; }
    
    
    public Subscription(DateTime? expireDate)
    {
      CreateDate = DateTime.Now;
      LastUpdateDate = DateTime.Now;
      ExpireDate = expireDate;
      Active = true;
      _payments = new List<Payment>();
    }

    public void AddPayment(Payment payment)
    {
      _payments.Add(payment);
    }

    public void Activate()
    {
      Active = true;
      LastUpdateDate = DateTime.Now;
    }
    
    public void Inactivate()
    {
      Active = false;
      LastUpdateDate = DateTime.Now;
    }
  }
}