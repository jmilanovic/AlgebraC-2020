﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fakultet.Models;

namespace Fakultet.Controllers
{
    public class PredsController : Controller
    {
        private readonly faksContext _context;

        public PredsController(faksContext context)
        {
            _context = context;
        }

        // GET: Preds
        public async Task<IActionResult> Index()
        {
            var faksContext = _context.Preds.Include(p => p.SifOrgjedNavigation);
            return View(await faksContext.ToListAsync());
        }

        // GET: Preds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pred = await _context.Preds
                .Include(p => p.SifOrgjedNavigation)
                .FirstOrDefaultAsync(m => m.SifPred == id);
            if (pred == null)
            {
                return NotFound();
            }

            return View(pred);
        }

        // GET: Preds/Create
        public IActionResult Create()
        {
            ViewData["SifOrgjed"] = new SelectList(_context.Orgjeds, "SifOrgjed", "NazOrgjed");
            return View();
        }

        // POST: Preds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SifPred,KratPred,NazPred,SifOrgjed,UpisanoStud,BrojSatiTjedno")] Pred pred)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pred);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SifOrgjed"] = new SelectList(_context.Orgjeds, "SifOrgjed", "NazOrgjed", pred.SifOrgjed);
            return View(pred);
        }

        // GET: Preds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pred = await _context.Preds.FindAsync(id);
            if (pred == null)
            {
                return NotFound();
            }
            ViewData["SifOrgjed"] = new SelectList(_context.Orgjeds, "SifOrgjed", "NazOrgjed", pred.SifOrgjed);
            return View(pred);
        }

        // POST: Preds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SifPred,KratPred,NazPred,SifOrgjed,UpisanoStud,BrojSatiTjedno")] Pred pred)
        {
            if (id != pred.SifPred)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pred);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PredExists(pred.SifPred))
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
            ViewData["SifOrgjed"] = new SelectList(_context.Orgjeds, "SifOrgjed", "NazOrgjed", pred.SifOrgjed);
            return View(pred);
        }

        // GET: Preds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pred = await _context.Preds
                .Include(p => p.SifOrgjedNavigation)
                .FirstOrDefaultAsync(m => m.SifPred == id);
            if (pred == null)
            {
                return NotFound();
            }

            return View(pred);
        }

        // POST: Preds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pred = await _context.Preds.FindAsync(id);
            _context.Preds.Remove(pred);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PredExists(int id)
        {
            return _context.Preds.Any(e => e.SifPred == id);
        }
    }
}
