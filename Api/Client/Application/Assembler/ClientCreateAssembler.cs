using AutoMapper;
//using EnterprisePatterns.Api.BankAccounts.Application.Dto;
//using EnterprisePatterns.Api.BankAccounts.Domain.Entity;

namespace EnterprisePatterns.Api.Client.Application.Assembler
{
    using EnterprisePatterns.Api.Client.Application.Dto;
    using EnterprisePatterns.Api.Client.Domain.Entity;

    public class ClientCreateAssembler
    {
        private readonly IMapper _mapper;

        public ClientCreateAssembler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Client toEntity(ClientCreateDto bankAccountCreateDto)
        {
            return _mapper.Map<Client>(bankAccountCreateDto);
        }
    }
}
