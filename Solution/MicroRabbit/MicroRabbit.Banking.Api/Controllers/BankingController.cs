﻿
namespace MicroRabbit.Banking.Api.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using MicroRabbit.Banking.Application.Interfaces;
    using MicroRabbit.Banking.Application.Models;
    using MicroRabbit.Banking.Domain.Models;
    using Microsoft.AspNetCore.Mvc;


    /// <summary>
    /// Banking Api controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
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
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountService.GetAccounts());
        }

        /// <summary>
        /// Posts the specified account transfer.
        /// </summary>
        /// <param name="accountTransfer">The account transfer.</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] AccountTransfer accountTransfer)
        {
            _accountService.Transfer(accountTransfer);
            return Ok(accountTransfer);
        }

    }
}
