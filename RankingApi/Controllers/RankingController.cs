#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RankingApi;
using RankingApi.Context;

namespace RankingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RankingController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RankingController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Ranking
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ranking>>> GetRankings()
        {
            return await _context.Rankings.ToListAsync();
        }

        // GET: api/Ranking/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ranking>> GetRanking(int id)
        {
            var ranking = await _context.Rankings.FindAsync(id);

            if (ranking == null)
            {
                return NotFound();
            }

            return ranking;
        }

        // PUT: api/Ranking/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRanking(int id, Ranking ranking)
        {
            if (id != ranking.Id)
            {
                return BadRequest();
            }

            _context.Entry(ranking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RankingExists(id))
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

        // POST: api/Ranking
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ranking>> PostRanking(Ranking ranking)
        {
            _context.Rankings.Add(ranking);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRanking", new { id = ranking.Id }, ranking);
        }

        // DELETE: api/Ranking/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRanking(int id)
        {
            var ranking = await _context.Rankings.FindAsync(id);
            if (ranking == null)
            {
                return NotFound();
            }

            _context.Rankings.Remove(ranking);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RankingExists(int id)
        {
            return _context.Rankings.Any(e => e.Id == id);
        }
    }
}
