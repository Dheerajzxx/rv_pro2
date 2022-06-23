using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using webAPi3.Models;

namespace webAPi3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GearController : ControllerBase
    {
        private readonly AppDBContext _context;

        public GearController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/TodoItems
        [HttpGet]
        public IActionResult GetGears()
        {
            try
            {
                var gears = _context.Gears.ToList();
                return Ok(gears);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex); 
            }
        }

        // GET: api/TodoItems/5
        [HttpGet("{id}")]
        public IActionResult GetGear(int id)
        {
            try
            {
                var gear = _context.Gears.FirstOrDefault(e => e.Id == id);
                if (gear == null)
                {
                    return NotFound("Not Found");
                }
                return Ok(gear);

            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public IActionResult PostGear([FromBody]Gear gear)
        {
            try
            {
                _context.Gears.Add(gear);
                _context.SaveChanges();
                return Created("/api/Gear/{gear.id}", gear);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public IActionResult PutGear(int id, [FromBody] Gear gear)
        {
            try
            {
                var cntx = _context.Gears.FirstOrDefault(e => e.Id == id);
                if (cntx != null)
                {
                    cntx.name = gear.name;
                    cntx.price = gear.price;
                    cntx.stock = gear.stock;
                    _context.SaveChanges();
                    return Ok(cntx);
                }
                else
                {
                    return NotFound("Record not found");
                }

            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
            
        }
    }
}
