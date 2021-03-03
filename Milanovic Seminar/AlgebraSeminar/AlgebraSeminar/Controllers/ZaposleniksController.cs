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
    public class ZaposleniksController : Controller
    {
        private readonly AlgebraContext _context;

        public ZaposleniksController(AlgebraContext context)
        {
            _context = context;
        }

        // GET: Zaposleniks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Zaposleniks.ToListAsync());
        }

        // GET: Zaposleniks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zaposlenik = await _context.Zaposleniks
                .FirstOrDefaultAsync(m => m.IdZaposlenik == id);
            if (zaposlenik == null)
            {
                return NotFound();
            }

            return View(zaposlenik);
        }

        // GET: Zaposleniks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Zaposleniks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdZaposlenik,Ime,Prezime,KorisnickoIme,Password")] Zaposlenik zaposlenik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zaposlenik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zaposlenik);
        }

        // GET: Zaposleniks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zaposlenik = await _context.Zaposleniks.FindAsync(id);
            if (zaposlenik == null)
            {
                return NotFound();
            }
            return View(zaposlenik);
        }

        // POST: Zaposleniks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdZaposlenik,Ime,Prezime,KorisnickoIme,Password")] Zaposlenik zaposlenik)
        {
            if (id != zaposlenik.IdZaposlenik)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zaposlenik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZaposlenikExists(zaposlenik.IdZaposlenik))
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
            return View(zaposlenik);
        }

        // GET: Zaposleniks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zaposlenik = await _context.Zaposleniks
                .FirstOrDefaultAsync(m => m.IdZaposlenik == id);
            if (zaposlenik == null)
            {
                return NotFound();
            }

            return View(zaposlenik);
        }

        // POST: Zaposleniks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zaposlenik = await _context.Zaposleniks.FindAsync(id);
            _context.Zaposleniks.Remove(zaposlenik);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZaposlenikExists(int id)
        {
            return _context.Zaposleniks.Any(e => e.IdZaposlenik == id);
        }
    }
}
