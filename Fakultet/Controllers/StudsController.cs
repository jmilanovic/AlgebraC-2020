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
    public class StudsController : Controller
    {
        private readonly faksContext _context;

        public StudsController(faksContext context)
        {
            _context = context;
        }

        // GET: Studs
        public async Task<IActionResult> Index()
        {
            var faksContext = _context.Studs.Include(s => s.PbrRodNavigation).Include(s => s.PbrStanNavigation);
            return View(await faksContext.ToListAsync());
        }

        // GET: Studs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stud = await _context.Studs
                .Include(s => s.PbrRodNavigation)
                .Include(s => s.PbrStanNavigation)
                .FirstOrDefaultAsync(m => m.MbrStud == id);
            if (stud == null)
            {
                return NotFound();
            }

            return View(stud);
        }

        // GET: Studs/Create
        public IActionResult Create()
        {
            ViewData["PbrRod"] = new SelectList(_context.Mjestos, "Pbr", "NazMjesto");
            ViewData["PbrStan"] = new SelectList(_context.Mjestos, "Pbr", "NazMjesto");
            return View();
        }

        // POST: Studs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MbrStud,ImeStud,PrezStud,PbrRod,PbrStan,DatRodStud,JmbgStud")] Stud stud)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stud);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PbrRod"] = new SelectList(_context.Mjestos, "Pbr", "NazMjesto", stud.PbrRod);
            ViewData["PbrStan"] = new SelectList(_context.Mjestos, "Pbr", "NazMjesto", stud.PbrStan);
            return View(stud);
        }

        // GET: Studs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stud = await _context.Studs.FindAsync(id);
            if (stud == null)
            {
                return NotFound();
            }
            ViewData["PbrRod"] = new SelectList(_context.Mjestos, "Pbr", "NazMjesto", stud.PbrRod);
            ViewData["PbrStan"] = new SelectList(_context.Mjestos, "Pbr", "NazMjesto", stud.PbrStan);
            return View(stud);
        }

        // POST: Studs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MbrStud,ImeStud,PrezStud,PbrRod,PbrStan,DatRodStud,JmbgStud")] Stud stud)
        {
            if (id != stud.MbrStud)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stud);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudExists(stud.MbrStud))
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
            ViewData["PbrRod"] = new SelectList(_context.Mjestos, "Pbr", "NazMjesto", stud.PbrRod);
            ViewData["PbrStan"] = new SelectList(_context.Mjestos, "Pbr", "NazMjesto", stud.PbrStan);
            return View(stud);
        }

        // GET: Studs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stud = await _context.Studs
                .Include(s => s.PbrRodNavigation)
                .Include(s => s.PbrStanNavigation)
                .FirstOrDefaultAsync(m => m.MbrStud == id);
            if (stud == null)
            {
                return NotFound();
            }

            return View(stud);
        }

        // POST: Studs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stud = await _context.Studs.FindAsync(id);
            _context.Studs.Remove(stud);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudExists(int id)
        {
            return _context.Studs.Any(e => e.MbrStud == id);
        }
    }
}
