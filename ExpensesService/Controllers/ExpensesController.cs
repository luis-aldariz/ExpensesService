using ExpensesService.Data;
using ExpensesService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExpensesService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpensesController : ControllerBase
    {
        private readonly ILogger<ExpensesController> _logger;
        private readonly ProjectContext _context;

        public ExpensesController(ILogger<ExpensesController> logger, ProjectContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetExpenseTypes")]
        public async Task<IEnumerable<ExpenseType>> GetExpenseTypes()
        {
            return await _context.ExpenseTypes.Where(t => t.IsActive).ToListAsync();
        }
    }
}
