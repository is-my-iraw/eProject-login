#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Dev4Fun_Sem3_eProject.Data;
using Dev4Fun_Sem3_eProject.Models;

namespace Dev4Fun_Sem3_eProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantVacanciesController : ControllerBase
    {
        private readonly Dev4Fun_Sem3_eProjectContext _context;

        public ApplicantVacanciesController(Dev4Fun_Sem3_eProjectContext context)
        {
            _context = context;
        }

        // GET: api/ApplicantVacancies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApplicantVacancy>>> GetApplicantVacancy()
        {
            return await _context.ApplicantVacancy.ToListAsync();
        }

        // GET: api/ApplicantVacancies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ApplicantVacancy>> GetApplicantVacancy(int id)
        {
            var applicantVacancy = await _context.ApplicantVacancy.FindAsync(id);

            if (applicantVacancy == null)
            {
                return NotFound();
            }

            return applicantVacancy;
        }

        // PUT: api/ApplicantVacancies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApplicantVacancy(int id, ApplicantVacancy applicantVacancy)
        {
            if (id != applicantVacancy.Id)
            {
                return BadRequest();
            }

            _context.Entry(applicantVacancy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApplicantVacancyExists(id))
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

        // POST: api/ApplicantVacancies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ApplicantVacancy>> PostApplicantVacancy(ApplicantVacancy applicantVacancy)
        {
            _context.ApplicantVacancy.Add(applicantVacancy);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetApplicantVacancy", new { id = applicantVacancy.Id }, applicantVacancy);
        }

        // DELETE: api/ApplicantVacancies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApplicantVacancy(int id)
        {
            var applicantVacancy = await _context.ApplicantVacancy.FindAsync(id);
            if (applicantVacancy == null)
            {
                return NotFound();
            }

            _context.ApplicantVacancy.Remove(applicantVacancy);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ApplicantVacancyExists(int id)
        {
            return _context.ApplicantVacancy.Any(e => e.Id == id);
        }
    }
}
