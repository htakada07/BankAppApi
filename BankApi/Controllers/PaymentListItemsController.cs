using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BankApi.Models;

namespace BankApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentListItemsController : ControllerBase
    {
        private readonly BankContext _context;

        public PaymentListItemsController(BankContext context)
        {
            _context = context;
        }

        // GET: api/PaymentListItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaymentListItem>>> GetPaymentListItems()
        {
            return await _context.PaymentListItems.ToListAsync();
        }

        // GET: api/PaymentListItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PaymentListItem>> GetPaymentListItem(int id)
        {
            var paymentListItem = await _context.PaymentListItems.FindAsync(id);

            if (paymentListItem == null)
            {
                return NotFound();
            }

            return paymentListItem;
        }

        // GET: api/PaymentListItems/5
        [HttpGet("GetByUserId/{userId}")]
        public async Task<ActionResult<List<PaymentListItem>>> GetPaymentListByUserId(int userId)
        {
            var paymentListItem = await _context.PaymentListItems
                    .Include(s => s.User)
                    .OrderByDescending(s => s.Date)//sorts the data by date
                    .Where(s => s.UserId == userId).ToListAsync();

            if (paymentListItem.Count == 0) //checks if there are no data found
            {
                return NotFound();
            }

            return paymentListItem;
        }

        // PUT: api/PaymentListItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPaymentListItem(int id, PaymentListItem paymentListItem)
        {
            if (id != paymentListItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(paymentListItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaymentListItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PaymentListItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PaymentListItem>> PostPaymentListItem(PaymentListItem paymentListItem)
        {
            _context.PaymentListItems.Add(paymentListItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPaymentListItem", new { id = paymentListItem.Id }, paymentListItem);
        }

        // DELETE: api/PaymentListItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePaymentListItem(int id)
        {
            var paymentListItem = await _context.PaymentListItems.FindAsync(id);
            if (paymentListItem == null)
            {
                return NotFound();
            }

            _context.PaymentListItems.Remove(paymentListItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PaymentListItemExists(int id)
        {
            return _context.PaymentListItems.Any(e => e.Id == id);
        }
    }
}
