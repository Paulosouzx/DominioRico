namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        private IList<Subscription> _subscriptions;
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }
        //assim nao consigo colocar o metodo , ja que temos que passar pelo metodo AddSubscription e cancelar todas as outras Subs.
        public IReadOnlyCollection<Subscription> Subscriptions {
            get { return _subscriptions.ToArray(); }
        }

        public Student(string firstName, string lastName, string document, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
        }

        public void AddSubscription(Subscription subscription)
        {
            foreach (var subs in Subscriptions)
                subs.Activate();
            
            _subscriptions.Add(subscription);
        }

    }

}