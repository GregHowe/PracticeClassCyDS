using AutoMapper;
using EnterprisePatterns.Api.BankAccounts.Application.Dto;
using EnterprisePatterns.Api.Client.Domain.Entity;
using EnterprisePatterns.Api.Common.Domain.ValueObject;
using EnterprisePatterns.Api.Customers;

namespace EnterprisePatterns.Api.Client.Application.Assembler
{
    public class ClientCreateProfile : Profile
    {
        public ClientCreateProfile()
        {
            CreateMap<ClientCreateDto, Client>()
                .ForMember(
                    dest => dest.Balance,
                    opts => opts.MapFrom(
                        src => new Money(src.Balance, src.Currency)
                    )
                )
                .ForMember(
                    dest => dest.Customer,
                    opts => opts.MapFrom(
                        src => new Customer
                        {
                            Id = src.CustomerId
                        }
                    )
                ).ReverseMap();
        }
    }
}
