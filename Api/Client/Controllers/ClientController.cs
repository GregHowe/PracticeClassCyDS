using Microsoft.AspNetCore.Mvc;
//using EnterprisePatterns.Api.BankAccounts.Application.Dto;
using Microsoft.AspNetCore.Http;
using EnterprisePatterns.Api.Client.Application.Assembler;
using EnterprisePatterns.Api.Client.Domain.Repository;
using EnterprisePatterns.Api.Common.Application.Dto;
using System;
using EnterprisePatterns.Api.Common.Application;
using EnterprisePatterns.Api.Client.Application.Dto;


namespace EnterprisePatterns.Api.Controllers
{
    using EnterprisePatterns.Api.Client.Domain.Entity;

    [Route("v1/client/{customerId}/client")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IClientRepository _clientRepository;
        private readonly ClientCreateAssembler _clientCreateAssembler;

        public ClientController(
            IUnitOfWork unitOfWork,
            IClientRepository bankAccountRepository,
            ClientCreateAssembler bankAccountCreateAssembler)
        {
            _unitOfWork = unitOfWork;
            _clientRepository = bankAccountRepository;
            _clientCreateAssembler = bankAccountCreateAssembler;
        }

        [HttpPost]
        public IActionResult Create(long customerId, [FromBody] ClientCreateDto clientCreateDto)
        {
            bool uowStatus = false;
            try
            {
                uowStatus = _unitOfWork.BeginTransaction();
                clientCreateDto.CustomerId = customerId;
                Client  client = _clientCreateAssembler.toEntity(clientCreateDto);
                _clientRepository.Create(client);
                _unitOfWork.Commit(uowStatus);
                return StatusCode(StatusCodes.Status201Created, new ApiStringResponseDto("client Created!"));
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback(uowStatus);
                Console.WriteLine(ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, new ApiStringResponseDto("Internal Server Error"));

            }
        }
    }
}
