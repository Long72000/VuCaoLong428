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
    public class VCL0428Controller : Controller
    {
        private readonly VuCaoLong428Context _context;

        public VCL0428Controller(VuCaoLong428Context context)
        {
            _context = context;
        }

        // GET: VCL0428
        public async Task<IActionResult> Index()
        {
            return View(await _context.VCL0428.ToListAsync());
        }

        // GET: VCL0428/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vCL0428 = await _context.VCL0428
                .FirstOrDefaultAsync(m => m.VCLId == id);
            if (vCL0428 == null)
            {
                return NotFound();
            }

            return View(vCL0428);
        }

        // GET: VCL0428/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VCL0428/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VCLId,VCLName,VCLGender")] VCL0428 vCL0428)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vCL0428);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vCL0428);
        }

        // GET: VCL0428/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vCL0428 = await _context.VCL0428.FindAsync(id);
            if (vCL0428 == null)
            {
                return NotFound();
            }
            return View(vCL0428);
        }

        // POST: VCL0428/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("VCLId,VCLName,VCLGender")] VCL0428 vCL0428)
        {
            if (id != vCL0428.VCLId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vCL0428);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VCL0428Exists(vCL0428.VCLId))
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
            return View(vCL0428);
        }

        // GET: VCL0428/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vCL0428 = await _context.VCL0428
                .FirstOrDefaultAsync(m => m.VCLId == id);
            if (vCL0428 == null)
            {
                return NotFound();
            }

            return View(vCL0428);
        }

        // POST: VCL0428/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var vCL0428 = await _context.VCL0428.FindAsync(id);
            _context.VCL0428.Remove(vCL0428);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VCL0428Exists(string id)
        {
            return _context.VCL0428.Any(e => e.VCLId == id);
        }
    }
}
