using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRM.Data;
using CRM.Models;

namespace CRM.Controllers
{
    public class CliesntsHistoriesController : Controller
    {
        private readonly CrmContext _context;

        public CliesntsHistoriesController(CrmContext context)
        {
            _context = context;
        }

        // GET: CliesntsHistories
        public async Task<IActionResult> Index()
        {
              return View(await _context.CliesntsHistory.ToListAsync());
        }

        // GET: CliesntsHistories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CliesntsHistory == null)
            {
                return NotFound();
            }

            var cliesntsHistory = await _context.CliesntsHistory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cliesntsHistory == null)
            {
                return NotFound();
            }

            return View(cliesntsHistory);
        }

        // GET: CliesntsHistories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CliesntsHistories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClientName,Adress,CarName,Price,TgId,PhoneNumber,TimeJob,IdStaff")] CliesntsHistory cliesntsHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliesntsHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cliesntsHistory);
        }

        // GET: CliesntsHistories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CliesntsHistory == null)
            {
                return NotFound();
            }

            var cliesntsHistory = await _context.CliesntsHistory.FindAsync(id);
            if (cliesntsHistory == null)
            {
                return NotFound();
            }
            return View(cliesntsHistory);
        }

        // POST: CliesntsHistories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClientName,Adress,CarName,Price,TgId,PhoneNumber,TimeJob,IdStaff")] CliesntsHistory cliesntsHistory)
        {
            if (id != cliesntsHistory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cliesntsHistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CliesntsHistoryExists(cliesntsHistory.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cliesntsHistory);
        }

        // GET: CliesntsHistories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CliesntsHistory == null)
            {
                return NotFound();
            }

            var cliesntsHistory = await _context.CliesntsHistory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cliesntsHistory == null)
            {
                return NotFound();
            }

            return View(cliesntsHistory);
        }

        // POST: CliesntsHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CliesntsHistory == null)
            {
                return Problem("Entity set 'CrmContext.CliesntsHistory'  is null.");
            }
            var cliesntsHistory = await _context.CliesntsHistory.FindAsync(id);
            if (cliesntsHistory != null)
            {
                _context.CliesntsHistory.Remove(cliesntsHistory);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CliesntsHistoryExists(int id)
        {
          return _context.CliesntsHistory.Any(e => e.Id == id);
        }
    }
}
