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
    public class HDM0000Controller : Controller
    {
        private readonly HoangDucManh000Context _context;

        public HDM0000Controller(HoangDucManh000Context context)
        {
            _context = context;
        }

        // GET: HDM0000
        public async Task<IActionResult> Index()
        {
            return View(await _context.HDM0000.ToListAsync());
        }

        // GET: HDM0000/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hDM0000 = await _context.HDM0000
                .FirstOrDefaultAsync(m => m.HDMId == id);
            if (hDM0000 == null)
            {
                return NotFound();
            }

            return View(hDM0000);
        }

        // GET: HDM0000/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HDM0000/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HDMId,HDMName,HDMGender")] HDM0000 hDM0000)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hDM0000);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hDM0000);
        }

        // GET: HDM0000/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hDM0000 = await _context.HDM0000.FindAsync(id);
            if (hDM0000 == null)
            {
                return NotFound();
            }
            return View(hDM0000);
        }

        // POST: HDM0000/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("HDMId,HDMName,HDMGender")] HDM0000 hDM0000)
        {
            if (id != hDM0000.HDMId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hDM0000);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HDM0000Exists(hDM0000.HDMId))
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
            return View(hDM0000);
        }

        // GET: HDM0000/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hDM0000 = await _context.HDM0000
                .FirstOrDefaultAsync(m => m.HDMId == id);
            if (hDM0000 == null)
            {
                return NotFound();
            }

            return View(hDM0000);
        }

        // POST: HDM0000/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var hDM0000 = await _context.HDM0000.FindAsync(id);
            _context.HDM0000.Remove(hDM0000);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HDM0000Exists(string id)
        {
            return _context.HDM0000.Any(e => e.HDMId == id);
        }
    }
}
