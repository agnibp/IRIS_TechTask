using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.ViewModels;
using API.DAL;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BanksController : ControllerBase
    {
        private readonly BanksDBContext _context;
        public BanksController(BanksDBContext context)
        {
            _context = context;
        }

        [HttpGet("/api/banks/{bankid}")]
        public async Task<ActionResult<BankDetailData>> GetBankDetails(int bankid)
        {
            return await _context.BankDetails
                .Where(b => b.bank_id == bankid)
                .Select(data => new BankDetailData { bank_name = data.bank_name, bank_head_office_location = data.bank_head_office_location })
                .FirstOrDefaultAsync();
        }
    }
}
