
namespace MicroRabbit.Banking.Api.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using MicroRabbit.Banking.Application.Interfaces;
    using MicroRabbit.Banking.Domain.Models;
    using Microsoft.AspNetCore.Mvc;


    [Route("api/[controller]")]
    [ApiController]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;

        /// <summary>
        /// Initializes a new instance of the <see cref="BankingController"/> class.
        /// </summary>
        /// <param name="accountService">The account service.</param>
        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        /// <summary>
        // GET api/banking
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountService.GetAccounts());
        }

    }
}
