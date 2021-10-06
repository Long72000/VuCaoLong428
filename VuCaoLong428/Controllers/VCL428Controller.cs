using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VuCaoLong428.Data;
using VuCaoLong428.Models;

namespace VuCaoLong428.Controllers
{
    public class VCL428Controller : Controller
    {
        private readonly VuCaoLong428Context _context;

        public VCL428Controller(VuCaoLong428Context context)
        {
            _context = context;
        }

        // GET: VCL428
        public async Task<IActionResult> Index()
        {
            return View(await _context.VCL428.ToListAsync());
        }

        // GET: VCL428/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vCL428 = await _context.VCL428
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (vCL428 == null)
            {
                return NotFound();
            }

            return View(vCL428);
        }

        // GET: VCL428/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VCL428/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,PersonName")] VCL428 vCL428)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vCL428);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vCL428);
        }

        // GET: VCL428/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vCL428 = await _context.VCL428.FindAsync(id);
            if (vCL428 == null)
            {
                return NotFound();
            }
            return View(vCL428);
        }

        // POST: VCL428/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonId,PersonName")] VCL428 vCL428)
        {
            if (id != vCL428.PersonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vCL428);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VCL428Exists(vCL428.PersonId))
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
            return View(vCL428);
        }

        // GET: VCL428/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vCL428 = await _context.VCL428
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (vCL428 == null)
            {
                return NotFound();
            }

            return View(vCL428);
        }

        // POST: VCL428/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var vCL428 = await _context.VCL428.FindAsync(id);
            _context.VCL428.Remove(vCL428);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VCL428Exists(string id)
        {
            return _context.VCL428.Any(e => e.PersonId == id);
        }
    }
}
