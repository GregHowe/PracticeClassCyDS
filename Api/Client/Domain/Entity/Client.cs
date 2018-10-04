using EnterprisePatterns.Api.Common.Domain.ValueObject;
using EnterprisePatterns.Api.Customers;

namespace EnterprisePatterns.Api.Client.Domain.Entity
{
    public class Client
    {
        public virtual long Id { get; set; }
        public virtual string Number { get; set; }
        public virtual Money Balance { get; set; }
        public virtual bool Locked { get; set; }
        public virtual Customer Customer { get; set; }

        public Client()
        {
        }

    }
}
