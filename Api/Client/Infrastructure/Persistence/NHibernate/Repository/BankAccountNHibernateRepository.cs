using EnterprisePatterns.Api.Client.Domain.Repository;
using EnterprisePatterns.Api.Common.Infrastructure.Persistence.NHibernate;

namespace EnterprisePatterns.Api.Client.Infrastructure.Persistence.NHibernate.Repository
{
    using EnterprisePatterns.Api.Client.Domain.Entity;

    public class ClientNHibernateRepository : BaseNHibernateRepository<Client>, IClientRepository
    {
        public ClientNHibernateRepository(UnitOfWorkNHibernate unitOfWork) : base(unitOfWork)
        {
        }
    }
}
