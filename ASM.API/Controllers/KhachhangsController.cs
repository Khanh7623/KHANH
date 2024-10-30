using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASM.Share.Models;

namespace ASM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Khachhang1sController : ControllerBase
    {
        private readonly DataContext _context;

        public Khachhang1sController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Khachhangs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Khachhang>>> GetKhachhangs()
        {
            return await _context.Khachhangs.ToListAsync();
        }

        // GET: api/Khachhangs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Khachhang>> GetKhachhang(int id)
        {
            var khachhang = await _context.Khachhangs.FindAsync(id);

            if (khachhang == null)
            {
                return NotFound();
            }

            return khachhang;
        }

        // PUT: api/Khachhangs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKhachhang(int id, Khachhang khachhang)
        {
            if (id != khachhang.KhachhangID)
            {
                return BadRequest();
            }

            _context.Entry(khachhang).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KhachhangExists(id))
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

        // POST: api/Khachhangs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Khachhang>> PostKhachhang(Khachhang khachhang)
        {
            _context.Khachhangs.Add(khachhang);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKhachhang", new { id = khachhang.KhachhangID }, khachhang);
        }

        // DELETE: api/Khachhangs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKhachhang(int id)
        {
            var khachhang = await _context.Khachhangs.FindAsync(id);
            if (khachhang == null)
            {
                return NotFound();
            }

            _context.Khachhangs.Remove(khachhang);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KhachhangExists(int id)
        {
            return _context.Khachhangs.Any(e => e.KhachhangID == id);
        }
    }
}
