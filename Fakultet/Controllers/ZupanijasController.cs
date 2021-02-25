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
    public class ZupanijasController : Controller
    {
        private readonly faksContext _context;

        public ZupanijasController(faksContext context)
        {
            _context = context;
        }

        // GET: Zupanijas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Zupanijas.ToListAsync());
        }

        // GET: Zupanijas/Details/5
        public async Task<IActionResult> Details(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zupanija = await _context.Zupanijas
                .FirstOrDefaultAsync(m => m.SifZupanija == id);
            if (zupanija == null)
            {
                return NotFound();
            }

            return View(zupanija);
        }

        // GET: Zupanijas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Zupanijas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SifZupanija,NazZupanija")] Zupanija zupanija)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zupanija);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zupanija);
        }

        // GET: Zupanijas/Edit/5
        public async Task<IActionResult> Edit(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zupanija = await _context.Zupanijas.FindAsync(id);
            if (zupanija == null)
            {
                return NotFound();
            }
            return View(zupanija);
        }

        // POST: Zupanijas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(short id, [Bind("SifZupanija,NazZupanija")] Zupanija zupanija)
        {
            if (id != zupanija.SifZupanija)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zupanija);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZupanijaExists(zupanija.SifZupanija))
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
            return View(zupanija);
        }

        // GET: Zupanijas/Delete/5
        public async Task<IActionResult> Delete(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zupanija = await _context.Zupanijas
                .FirstOrDefaultAsync(m => m.SifZupanija == id);
            if (zupanija == null)
            {
                return NotFound();
            }

            return View(zupanija);
        }

        // POST: Zupanijas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(short id)
        {
            var zupanija = await _context.Zupanijas.FindAsync(id);
            _context.Zupanijas.Remove(zupanija);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZupanijaExists(short id)
        {
            return _context.Zupanijas.Any(e => e.SifZupanija == id);
        }
    }
}
