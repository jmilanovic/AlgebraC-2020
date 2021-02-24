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
    public class DvoranasController : Controller
    {
        private readonly faksContext _context;

        public DvoranasController(faksContext context)
        {
            _context = context;
        }

        // GET: Dvoranas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dvoranas.ToListAsync());
        }

        // GET: Dvoranas/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dvorana = await _context.Dvoranas
                .FirstOrDefaultAsync(m => m.OznDvorana == id);
            if (dvorana == null)
            {
                return NotFound();
            }

            return View(dvorana);
        }

        // GET: Dvoranas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dvoranas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OznDvorana,Kapacitet")] Dvorana dvorana)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dvorana);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dvorana);
        }

        // GET: Dvoranas/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dvorana = await _context.Dvoranas.FindAsync(id);
            if (dvorana == null)
            {
                return NotFound();
            }
            return View(dvorana);
        }

        // POST: Dvoranas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("OznDvorana,Kapacitet")] Dvorana dvorana)
        {
            if (id != dvorana.OznDvorana)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dvorana);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DvoranaExists(dvorana.OznDvorana))
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
            return View(dvorana);
        }

        // GET: Dvoranas/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dvorana = await _context.Dvoranas
                .FirstOrDefaultAsync(m => m.OznDvorana == id);
            if (dvorana == null)
            {
                return NotFound();
            }

            return View(dvorana);
        }

        // POST: Dvoranas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var dvorana = await _context.Dvoranas.FindAsync(id);
            _context.Dvoranas.Remove(dvorana);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DvoranaExists(string id)
        {
            return _context.Dvoranas.Any(e => e.OznDvorana == id);
        }
    }
}
