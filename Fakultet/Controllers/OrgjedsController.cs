using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fakultet.Models;

namespace Fakultet.Controllers
{
    public class OrgjedsController : Controller
    {
        private readonly faksContext _context;

        public OrgjedsController(faksContext context)
        {
            _context = context;
        }

        // GET: Orgjeds
        public async Task<IActionResult> Index()
        {
            var faksContext = _context.Orgjeds.Include(o => o.SifNadorgjedNavigation);
            return View(await faksContext.ToListAsync());
        }

        // GET: Orgjeds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orgjed = await _context.Orgjeds
                .Include(o => o.SifNadorgjedNavigation)
                .FirstOrDefaultAsync(m => m.SifOrgjed == id);
            if (orgjed == null)
            {
                return NotFound();
            }

            return View(orgjed);
        }

        // GET: Orgjeds/Create
        public IActionResult Create()
        {
            ViewData["SifNadorgjed"] = new SelectList(_context.Orgjeds, "SifOrgjed", "NazOrgjed");
            return View();
        }

        // POST: Orgjeds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SifOrgjed,NazOrgjed,SifNadorgjed")] Orgjed orgjed)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orgjed);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SifNadorgjed"] = new SelectList(_context.Orgjeds, "SifOrgjed", "NazOrgjed", orgjed.SifNadorgjed);
            return View(orgjed);
        }

        // GET: Orgjeds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orgjed = await _context.Orgjeds.FindAsync(id);
            if (orgjed == null)
            {
                return NotFound();
            }
            ViewData["SifNadorgjed"] = new SelectList(_context.Orgjeds, "SifOrgjed", "NazOrgjed", orgjed.SifNadorgjed);
            return View(orgjed);
        }

        // POST: Orgjeds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SifOrgjed,NazOrgjed,SifNadorgjed")] Orgjed orgjed)
        {
            if (id != orgjed.SifOrgjed)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orgjed);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrgjedExists(orgjed.SifOrgjed))
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
            ViewData["SifNadorgjed"] = new SelectList(_context.Orgjeds, "SifOrgjed", "NazOrgjed", orgjed.SifNadorgjed);
            return View(orgjed);
        }

        // GET: Orgjeds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orgjed = await _context.Orgjeds
                .Include(o => o.SifNadorgjedNavigation)
                .FirstOrDefaultAsync(m => m.SifOrgjed == id);
            if (orgjed == null)
            {
                return NotFound();
            }

            return View(orgjed);
        }

        // POST: Orgjeds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orgjed = await _context.Orgjeds.FindAsync(id);
            _context.Orgjeds.Remove(orgjed);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrgjedExists(int id)
        {
            return _context.Orgjeds.Any(e => e.SifOrgjed == id);
        }
    }
}
