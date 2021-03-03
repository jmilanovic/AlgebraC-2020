using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlgebraSeminar.Models;
using AlgebraSeminar.ViewModel;
using System.Dynamic;



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
        public async Task<IActionResult> Create(int? id)
        {
            ViewData["IdSeminar"] = new SelectList(_context.Seminars, "IdSeminar", "Naziv");
             var seminar_naziv2 = await _context.Seminars.OrderByDescending(i => i.IdSeminar == id).ToListAsync();
            ViewData["program"] = seminar_naziv2.Where(x => x.IdSeminar == id);
            foreach (var item in seminar_naziv2.Where(x => x.IdSeminar == id))
            {
                if (item.IdSeminar == id)
                {
                    ViewData["program"] = item.Naziv.ToString();
                    ViewData["ID"] = id;
                }
                else { ViewData["program"] = ""; }
            }
            
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

            var tecaj=await _context.Predbiljezbas.OrderBy(i => i.IdSeminar == id).ToListAsync();
            ViewData["IdSeminar"] = new SelectList(_context.Seminars, "IdSeminar", "Naziv");
            var seminar_naziv2 = await _context.Seminars.OrderByDescending(i => i.IdSeminar == 12).ToListAsync();
            ViewData["program"] = seminar_naziv2.Where(x => x.IdSeminar == 12);
            foreach (var item in seminar_naziv2.Where(x => x.IdSeminar == 12))
            {
                if (item.IdSeminar == 12)
                {
                    ViewData["program"] = item.Naziv.ToString();
                }
                else { ViewData["program"] = ""; }
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
                return RedirectToAction(nameof(Predbiljezbe));
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


        public IActionResult Predbiljezba(string pretrazi)
        {
            AlgebraContext sd = new AlgebraContext();
            List<Predbiljezba> predbiljezba = sd.Predbiljezbas.ToList();
            List<Seminar> seminar = sd.Seminars.ToList();
       

            var unos = from s in seminar
                       select new UnosViewModel { seminarVm = s };
            //Pretrazivanje
            if (pretrazi != null)
            {
                var seminar_trazenje = from m in seminar
                              //select m;
                              select new UnosViewModel { seminarVm = m };

                 return View(seminar_trazenje.Where(x => x.seminarVm.Naziv == pretrazi || pretrazi == null).ToList());
                
            }
            return View(unos);
        }
        public IActionResult Predbiljezbe(string pretrazi)
        {
            AlgebraContext sd = new AlgebraContext();
            List<Predbiljezba> predbiljezba = sd.Predbiljezbas.ToList();
            List<Seminar> seminar = sd.Seminars.ToList();

            var seminar1 = _context.Seminars.ToList();
            var predbiljezba1 = _context.Predbiljezbas.ToList();

            var unos = from s in predbiljezba
                       join st in seminar on s.IdSeminar equals st.IdSeminar into st2
                       from st in st2.DefaultIfEmpty()
                       select new UnosViewModel
                       {
                           Naziv = st.Naziv,
                           Ime = s.Ime,
                           Prezime = s.Prezime,
                           Datum = s.Datum,
                           Adresa = s.Adresa,
                           Email = s.Email,
                           Telefon = s.Telefon,
                           Status = s.Status,
                           IdPredbiljezba = s.IdPredbiljezba,
                           IdSeminar=s.IdSeminar

                       };
            //Pretrazivanje
            if (pretrazi != null)
            {
                var trazenje = from s in predbiljezba
                               join st in seminar on s.IdSeminar equals st.IdSeminar into st2
                               from st in st2.DefaultIfEmpty()
                               select new UnosViewModel
                               {
                                   Naziv = st.Naziv,
                                   Ime = s.Ime,
                                   Prezime = s.Prezime,
                                   Datum = s.Datum,
                                   Adresa = s.Adresa,
                                   Email = s.Email,
                                   Telefon = s.Telefon,
                                   Status = s.Status,
                                   IdPredbiljezba = s.IdPredbiljezba,
                                   IdSeminar = s.IdSeminar

                               };

                return View(trazenje.Where(x => x.Naziv == pretrazi || pretrazi == null).ToList());
            }
            return View(unos);
        }


    }

}

