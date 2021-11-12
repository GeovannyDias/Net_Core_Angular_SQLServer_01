using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        // Creamos un constructor e inyectar el contexto
        public CardController(ApplicationDbContext context) {
            _context = context;
        }

        // GET: api/<CardController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                // CreditCard → DbSet<CreditCard>
                var listCards = await _context.CreditCard.ToListAsync();
                return Ok(listCards);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            // return new string[] { "value1", "value2" };
        }

        // GET api/<CardController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var cardFound = await _context.CreditCard.FindAsync(id);
                if (cardFound == null)
                {
                    return NotFound();
                }
                return Ok(cardFound);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<CardController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreditCard card)
        {
            try
            {
                _context.Add(card);
                await _context.SaveChangesAsync();
                return Ok(card);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<CardController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] CreditCard card)
        {
            try
            {
                if(id != card.Id)
                {
                    return NotFound();
                }
                _context.Update(card);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Data update successfuly."});
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<CardController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var cardFound = await _context.CreditCard.FindAsync(id);
                if(cardFound == null)
                {
                    return NotFound();
                }
                _context.CreditCard.Remove(cardFound);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Data deleted successfuly."});
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
