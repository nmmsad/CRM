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
    public class StaffJobsController : Controller
    {
        private readonly CRMContext _context;

        public StaffJobsController(CRMContext context)
        {
            _context = context;
        }

        // GET: StaffJobs
        public async Task<IActionResult> Index()
        {
              return View(await _context.StaffJob.ToListAsync());
        }

        // GET: StaffJobs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.StaffJob == null)
            {
                return NotFound();
            }

            var staffJob = await _context.StaffJob
                .FirstOrDefaultAsync(m => m.Id == id);
            if (staffJob == null)
            {
                return NotFound();
            }

            return View(staffJob);
        }

        // GET: StaffJobs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StaffJobs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TgId,WorkName,AddDate,Price,Contact,HiddenPrice")] StaffJob staffJob)
        {
            if (ModelState.IsValid)
            {
                _context.Add(staffJob);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(staffJob);
        }

        // GET: StaffJobs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.StaffJob == null)
            {
                return NotFound();
            }

            var staffJob = await _context.StaffJob.FindAsync(id);
            if (staffJob == null)
            {
                return NotFound();
            }
            return View(staffJob);
        }

        // POST: StaffJobs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TgId,WorkName,AddDate,Price,Contact,HiddenPrice")] StaffJob staffJob)
        {
            if (id != staffJob.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(staffJob);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StaffJobExists(staffJob.Id))
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
            return View(staffJob);
        }

        // GET: StaffJobs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.StaffJob == null)
            {
                return NotFound();
            }

            var staffJob = await _context.StaffJob
                .FirstOrDefaultAsync(m => m.Id == id);
            if (staffJob == null)
            {
                return NotFound();
            }

            return View(staffJob);
        }

        // POST: StaffJobs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.StaffJob == null)
            {
                return Problem("Entity set 'CRMContext.StaffJob'  is null.");
            }
            var staffJob = await _context.StaffJob.FindAsync(id);
            if (staffJob != null)
            {
                _context.StaffJob.Remove(staffJob);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StaffJobExists(int id)
        {
          return _context.StaffJob.Any(e => e.Id == id);
        }
    }
}
