using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Job_Portal_API.Data;
using Job_Portal_API.Models;

namespace Job_Portal_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobPortalsController : ControllerBase
    {
        private readonly Job_Portal_APIContext _context;

        public JobPortalsController(Job_Portal_APIContext context)
        {
            _context = context;
        }

        // GET: api/JobPortals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobPortal>>> GetJobPortal()
        {
            return await _context.JobPortal.ToListAsync();
        }

        // GET: api/JobPortals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JobPortal>> GetJobPortal(int id)
        {
            var jobPortal = await _context.JobPortal.FindAsync(id);

            if (jobPortal == null)
            {
                return NotFound();
            }

            return jobPortal;
        }

        // PUT: api/JobPortals/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJobPortal(int id, JobPortal jobPortal)
        {
            if (id != jobPortal.Id)
            {
                return BadRequest();
            }

            _context.Entry(jobPortal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobPortalExists(id))
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

        // POST: api/JobPortals
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<JobPortal>> PostJobPortal(JobPortal jobPortal)
        {
            _context.JobPortal.Add(jobPortal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJobPortal", new { id = jobPortal.Id }, jobPortal);
        }

        // DELETE: api/JobPortals/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<JobPortal>> DeleteJobPortal(int id)
        {
            var jobPortal = await _context.JobPortal.FindAsync(id);
            if (jobPortal == null)
            {
                return NotFound();
            }

            _context.JobPortal.Remove(jobPortal);
            await _context.SaveChangesAsync();

            return jobPortal;
        }

        private bool JobPortalExists(int id)
        {
            return _context.JobPortal.Any(e => e.Id == id);
        }
    }
}
