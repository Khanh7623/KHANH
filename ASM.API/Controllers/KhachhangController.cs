using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASM.Share.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;

namespace ASM.API.Controllers
{    
    [Route("api/[controller]")]
    [ApiController]
    public class KhachhangController : ControllerBase
    {
        private readonly IKhachhangSvc _khachhangSvc;
        public KhachhangController(IKhachhangSvc khachhangSvc)
        {
            _khachhangSvc = khachhangSvc;   
        }

        // POST: api/Khachhang
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[AllowAnonymous]
        [HttpPost]        
        public async Task<ActionResult<int>> PostKhachhang(Khachhang khachhang)
        {
            try
            {
                //int id= await _khachhangSvc.AddKhachhang(khachhang);
                int id = await _khachhangSvc.AddKhachhangAsync(khachhang);
                khachhang.KhachhangID = id;
            }
            catch (Exception ex)
            {
               // return BadRequest(-1);
            }
            return Ok(1);
        }

        [HttpGet]
        public async Task<ActionResult<Khachhang>> GetKhachhang(int id)
        {
            try
            {
                //int id= await _khachhangSvc.AddKhachhang(khachhang);
                //var khachhang = await _khachhangSvc.GetKhachhang(id);
                //khachhang.KhachhangID = id;
            }
            catch (Exception ex)
            {
                // return BadRequest(-1);
            }
            return Ok(1);
        }
    }
}
