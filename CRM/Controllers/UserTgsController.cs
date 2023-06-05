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
    public class UserTgsController : Controller
    {
        private readonly CrmContext _context;

        public UserTgsController(CrmContext context)
        {
            _context = context;
        }

        // GET: UserTgs
        public async Task<IActionResult> Index()
        {
              return View(await _context.UserTg.ToListAsync());
        }

        // GET: UserTgs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.UserTg == null)
            {
                return NotFound();
            }

            var userTg = await _context.UserTg
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userTg == null)
            {
                return NotFound();
            }

            return View(userTg);
        }

        // GET: UserTgs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserTgs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,UserName,RequestTime,IsRequest")] UserTg userTg)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userTg);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userTg);
        }

        // GET: UserTgs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.UserTg == null)
            {
                return NotFound();
            }

            var userTg = await _context.UserTg.FindAsync(id);
            if (userTg == null)
            {
                return NotFound();
            }
            return View(userTg);
        }

        // POST: UserTgs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,UserName,RequestTime,IsRequest")] UserTg userTg)
        {
            if (id != userTg.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userTg);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserTgExists(userTg.Id))
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
            return View(userTg);
        }

        // GET: UserTgs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.UserTg == null)
            {
                return NotFound();
            }

            var userTg = await _context.UserTg
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userTg == null)
            {
                return NotFound();
            }

            return View(userTg);
        }

        // POST: UserTgs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.UserTg == null)
            {
                return Problem("Entity set 'CrmContext.UserTg'  is null.");
            }
            var userTg = await _context.UserTg.FindAsync(id);
            if (userTg != null)
            {
                _context.UserTg.Remove(userTg);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserTgExists(int id)
        {
          return _context.UserTg.Any(e => e.Id == id);
        }
    }
}
