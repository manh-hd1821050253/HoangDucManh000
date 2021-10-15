using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HoangDucManh000.Data;
using HoangDucManh000.Models;

namespace HoangDucManh000.Controllers
{
    public class PersonHDM000Controller : Controller
    {
        private readonly HoangDucManh000Context _context;

        public PersonHDM000Controller(HoangDucManh000Context context)
        {
            _context = context;
        }

        // GET: PersonHDM000
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonHDM000.ToListAsync());
        }

        // GET: PersonHDM000/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personHDM000 = await _context.PersonHDM000
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personHDM000 == null)
            {
                return NotFound();
            }

            return View(personHDM000);
        }

        // GET: PersonHDM000/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonHDM000/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,PersonName")] PersonHDM000 personHDM000)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personHDM000);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personHDM000);
        }

        // GET: PersonHDM000/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personHDM000 = await _context.PersonHDM000.FindAsync(id);
            if (personHDM000 == null)
            {
                return NotFound();
            }
            return View(personHDM000);
        }

        // POST: PersonHDM000/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersonId,PersonName")] PersonHDM000 personHDM000)
        {
            if (id != personHDM000.PersonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personHDM000);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonHDM000Exists(personHDM000.PersonId))
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
            return View(personHDM000);
        }

        // GET: PersonHDM000/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personHDM000 = await _context.PersonHDM000
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personHDM000 == null)
            {
                return NotFound();
            }

            return View(personHDM000);
        }

        // POST: PersonHDM000/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personHDM000 = await _context.PersonHDM000.FindAsync(id);
            _context.PersonHDM000.Remove(personHDM000);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonHDM000Exists(int id)
        {
            return _context.PersonHDM000.Any(e => e.PersonId == id);
        }
    }
}
