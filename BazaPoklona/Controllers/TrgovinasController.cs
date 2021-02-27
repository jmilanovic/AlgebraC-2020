using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BazaPoklona.Models;

namespace BazaPoklona.Controllers
{
    public class TrgovinasController : Controller
    {
        private readonly BazaPoklonaContext _context;

        public TrgovinasController(BazaPoklonaContext context)
        {
            _context = context;
        }

        // GET: Trgovinas
        public async Task<IActionResult> Index()
        {
            var bazaPoklonaContext = _context.Trgovinas.Include(t => t.VrstaRobeNavigation);
            return View(await bazaPoklonaContext.ToListAsync());
        }

        // GET: Trgovinas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trgovina = await _context.Trgovinas
                .Include(t => t.VrstaRobeNavigation)
                .FirstOrDefaultAsync(m => m.IdTrgovina == id);
            if (trgovina == null)
            {
                return NotFound();
            }

            return View(trgovina);
        }

        // GET: Trgovinas/Create
        public IActionResult Create()
        {
            ViewData["VrstaRobe"] = new SelectList(_context.VrstaRobes, "Id", "Naziv");
            return View();
        }

        // POST: Trgovinas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTrgovina,NazivTrgovina,VrstaRobe")] Trgovina trgovina)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trgovina);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["VrstaRobe"] = new SelectList(_context.VrstaRobes, "Id", "Naziv", trgovina.VrstaRobe);
            return View(trgovina);
        }

        // GET: Trgovinas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trgovina = await _context.Trgovinas.FindAsync(id);
            if (trgovina == null)
            {
                return NotFound();
            }
            ViewData["VrstaRobe"] = new SelectList(_context.VrstaRobes, "Id", "Naziv", trgovina.VrstaRobe);
            return View(trgovina);
        }

        // POST: Trgovinas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTrgovina,NazivTrgovina,VrstaRobe")] Trgovina trgovina)
        {
            if (id != trgovina.IdTrgovina)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trgovina);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrgovinaExists(trgovina.IdTrgovina))
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
            ViewData["VrstaRobe"] = new SelectList(_context.VrstaRobes, "Id", "Naziv", trgovina.VrstaRobe);
            return View(trgovina);
        }

        // GET: Trgovinas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trgovina = await _context.Trgovinas
                .Include(t => t.VrstaRobeNavigation)
                .FirstOrDefaultAsync(m => m.IdTrgovina == id);
            if (trgovina == null)
            {
                return NotFound();
            }

            return View(trgovina);
        }

        // POST: Trgovinas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trgovina = await _context.Trgovinas.FindAsync(id);
            _context.Trgovinas.Remove(trgovina);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrgovinaExists(int id)
        {
            return _context.Trgovinas.Any(e => e.IdTrgovina == id);
        }
    }
}
