using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ZawodyWedkarskie.API.Data;
using ZawodyWedkarskie.API.Models;

namespace ZawodyWedkarskie.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class KolaController : ControllerBase
    {
        private readonly ZawodyWedkarskieContext _context;

        public KolaController(ZawodyWedkarskieContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Values()
        {
            var kola = await _context.Kola.ToListAsync();
            return Ok(kola);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Value(int id)
        {
            var kola = await _context.Kola.FirstOrDefaultAsync(x => x.IdKola == id);
            return Ok(kola);
        }

        [HttpPost]
        public async Task<IActionResult> SaveNewValue([FromBody]Kolo value)
        {
            _context.Add(value);
            await _context.SaveChangesAsync();
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateValue(int id, [FromBody]Kolo value)
        {
            var data = await _context.Kola.FindAsync(id);
            data.Nazwa = value.Nazwa;
            _context.Kola.Update(data);
            await _context.SaveChangesAsync();
            return Ok(data);
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveValue(int id)
        {
            var data = await _context.Kola.FindAsync(id);
            if (data == null)
                return NoContent();

            _context.Kola.Remove(data);
            return Ok(data);
        }
    }
}