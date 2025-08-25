using BL_QuickGrid_Wasm_Net8.Data;
using BL_QuickGrid_Wasm_Net8.Shared.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BL_QuickGrid_Wasm_Net8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CustomerController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetAllCustomers()
        {
            var result = await _context.Customers.ToListAsync();
            return Ok(result);
        }
    }
}
