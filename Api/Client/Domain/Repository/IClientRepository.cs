
namespace EnterprisePatterns.Api.Client.Domain.Repository
{
    using EnterprisePatterns.Api.Client.Domain.Entity;

    public interface IClientRepository
    {
        void Create(Client bankAccount);
        void Delete(Client bankAccount);
        Client Read(long id);
    }
}
