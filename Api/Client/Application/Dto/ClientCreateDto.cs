using EnterprisePatterns.Api.Common.Application.Enum;
using System;

namespace EnterprisePatterns.Api.Client.Application.Dto
{
    public class ClientCreateDto
    {
        public string Number { get; set; }
        public Decimal Balance { get; set; }
        public Currency Currency { get; set; }
        public bool Locked { get; set; }
        public long CustomerId { get; set; }

        public ClientCreateDto()
        {
            Locked = false;
        }
    }
}
