using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlgebraSeminar.Models;
using AlgebraSeminar.ViewModel;

namespace AlgebraSeminar.Controllers
{
    public class SeminarsController : Controller
    {
        private readonly AlgebraContext _context;

        public SeminarsController(AlgebraContext context)
        {
            _context = context;
        }

        // GET: Seminars
        public async Task<IActionResult> Index()
        {
            return View(await _context.Seminars.ToListAsync());
        }
        public IActionResult Seminari(string pretrazi)
        {
                 AlgebraContext sd = new AlgebraContext();
            List<Predbiljezba> predbiljezba = sd.Predbiljezbas.ToList();
            List<Seminar> seminar = sd.Seminars.ToList();
           // var unos = from s in predbiljezba
           //            join st in seminar on s.IdSeminar equals st.IdSeminar into st2
           //            from st in st2.DefaultIfEmpty()
           //            select new UnosViewModel { predbiljezbaVm = s, seminarVm = st };

            var unos = from s in seminar
                       //join st in seminar on s.IdSeminar equals st.IdSeminar into st2
                       //from st in st2.DefaultIfEmpty()
                       select new UnosViewModel { seminarVm = s };
            //Pretrazivanje
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

        // GET: Seminars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seminar = await _context.Seminars
                .FirstOrDefaultAsync(m => m.IdSeminar == id);
            if (seminar == null)
            {
                return NotFound();
            }

            return View(seminar);
        }

        // GET: Seminars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Seminars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdSeminar,Naziv,Opis,Datum,Popunjen,Predavac")] Seminar seminar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(seminar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Seminari));
            }
            return View(seminar);
        }

        // GET: Seminars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seminar = await _context.Seminars.FindAsync(id);
            if (seminar == null)
            {
                return NotFound();
            }
            return View(seminar);
        }

        // POST: Seminars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdSeminar,Naziv,Opis,Datum,Popunjen,Predavac")] Seminar seminar)
        {
            if (id != seminar.IdSeminar)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(seminar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SeminarExists(seminar.IdSeminar))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Seminari));
            }
            return View(seminar);
        }

        // GET: Seminars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seminar = await _context.Seminars
                .FirstOrDefaultAsync(m => m.IdSeminar == id);
            if (seminar == null)
            {
                return NotFound();
            }

            return View(seminar);
        }

        // POST: Seminars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var seminar = await _context.Seminars.FindAsync(id);
            _context.Seminars.Remove(seminar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Seminari));
        }

        private bool SeminarExists(int id)
        {
            return _context.Seminars.Any(e => e.IdSeminar == id);
        }
    }
}
