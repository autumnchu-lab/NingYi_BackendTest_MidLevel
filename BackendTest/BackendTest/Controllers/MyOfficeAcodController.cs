using BackendTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendTest.Controllers
{
    [Route("api/myofficeacpd")]
    [ApiController]
    public class MyOfficeAcodController : ControllerBase
    {
        private readonly MercuryFireContext _context;

        public MyOfficeAcodController(MercuryFireContext context)
        {
            _context = context;
        }

        //Get: api/myofficeacpd
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MyOfficeAcpd>>> Get()
        {
            var list = await _context.MyOfficeAcpds.ToListAsync();
            return Ok(list); // 回傳 200 OK
        }

        //GET: api/myofficeacpd/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<MyOfficeAcpd>> GetId(string id)
        {
            var item = await _context.MyOfficeAcpds.FindAsync(id);
            if (item == null) return NotFound(); // 回傳 404 Not Found
            return Ok(item); // 回傳 200 OK
        }

        //POST: api/myofficeacpd
        [HttpPost]
        public async Task<ActionResult<MyOfficeAcpd>> Post([FromBody] MyOfficeAcpd data)
        {
            if (data == null) return BadRequest(); // 回傳 400 Bad Request

            _context.MyOfficeAcpds.Add(data);
            await _context.SaveChangesAsync();

            // 回傳 201 Created 並告知新資源的路徑
            return CreatedAtAction(nameof(GetId), new { id = data.AcpdSid }, data);
        }

        //PUT: api/myofficeacpd/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] MyOfficeAcpd data)
        {
            if (id != data.AcpdSid) return BadRequest("ID 不符"); // 回傳 400

            var existingItem = await _context.MyOfficeAcpds.AnyAsync(x => x.AcpdSid == id);
            if (!existingItem) return NotFound(); // 回傳 404

            _context.Entry(data).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok(data); // 或是依習慣回傳 200 OK 帶更新後的資料
        }

        //DELETE /api/myofficeacpd/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var item = await _context.MyOfficeAcpds.FindAsync(id);
            if (item == null) return NotFound(); // 回傳 404

            _context.MyOfficeAcpds.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent(); // 回傳 204 No Content
        }
    }
}

