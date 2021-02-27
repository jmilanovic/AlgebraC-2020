using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlgebraSeminar.Models;

namespace AlgebraSeminar.Controllers
{
    public class PredbiljezbasController : Controller
    {
        private readonly AlgebraContext _context;

        public PredbiljezbasController(AlgebraContext context)
        {
            _context = context;
        }

        // GET: Predbiljezbas
        public async Task<IActionResult> Index()
        {
            var algebraContext = _context.Predbiljezbas.Include(p => p.IdSeminarNavigation);
            return View(await algebraContext.ToListAsync());
        }

        // GET: Predbiljezbas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var predbiljezba = await _context.Predbiljezbas
                .Include(p => p.IdSeminarNavigation)
                .FirstOrDefaultAsync(m => m.IdPredbiljezba == id);
            if (predbiljezba == null)
            {
                return NotFound();
            }

            return View(predbiljezba);
        }

        // GET: Predbiljezbas/Create
        public IActionResult Create()
        {
            ViewData["IdSeminar"] = new SelectList(_context.Seminars, "IdSeminar", "Naziv");
            return View();
        }

        // POST: Predbiljezbas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPredbiljezba,Datum,Ime,Prezime,Adresa,Email,Telefon,IdSeminar,Status")] Predbiljezba predbiljezba)
        {
            if (ModelState.IsValid)
            {
                _context.Add(predbiljezba);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Predbiljezba));
            }
            ViewData["IdSeminar"] = new SelectList(_context.Seminars, "IdSeminar", "Naziv", predbiljezba.IdSeminar);
            return View(predbiljezba);
        }

        // GET: Predbiljezbas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var predbiljezba = await _context.Predbiljezbas.FindAsync(id);
            if (predbiljezba == null)
            {
                return NotFound();
            }
            ViewData["IdSeminar"] = new SelectList(_context.Seminars, "IdSeminar", "Naziv", predbiljezba.IdSeminar);
            return View(predbiljezba);
        }

        // POST: Predbiljezbas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPredbiljezba,Datum,Ime,Prezime,Adresa,Email,Telefon,IdSeminar,Status")] Predbiljezba predbiljezba)
        {
            if (id != predbiljezba.IdPredbiljezba)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(predbiljezba);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PredbiljezbaExists(predbiljezba.IdPredbiljezba))
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
            ViewData["IdSeminar"] = new SelectList(_context.Seminars, "IdSeminar", "Naziv", predbiljezba.IdSeminar);
            return View(predbiljezba);
        }

        // GET: Predbiljezbas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var predbiljezba = await _context.Predbiljezbas
                .Include(p => p.IdSeminarNavigation)
                .FirstOrDefaultAsync(m => m.IdPredbiljezba == id);
            if (predbiljezba == null)
            {
                return NotFound();
            }

            return View(predbiljezba);
        }

        // POST: Predbiljezbas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var predbiljezba = await _context.Predbiljezbas.FindAsync(id);
            _context.Predbiljezbas.Remove(predbiljezba);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PredbiljezbaExists(int id)
        {
            return _context.Predbiljezbas.Any(e => e.IdPredbiljezba == id);
        }

        public async Task<IActionResult> Predbiljezba()
        {
            return View(await _context.Predbiljezbas.ToListAsync());
        }
    }
}
