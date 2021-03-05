using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WorldWideImporters.DAL.Models.DB;

namespace WorldWideImporters.Controllers
{
    [ApiController]
    [Route("test")]
    public class TestController : ControllerBase
    {
        private readonly WideWorldImportersContext _context;
        private readonly ILogger<TestController> _logger;

        public TestController(WideWorldImportersContext context, ILogger<TestController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<Customer>> Get()
        {
            var customer = await _context.Customers.FindAsync(1);
            return customer;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Customer customer)
        {
            var result = await _context.AddAsync(customer);
            _context.SaveChanges();

            return Ok();
        }
    }
}
