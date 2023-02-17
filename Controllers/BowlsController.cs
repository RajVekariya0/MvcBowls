using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcBowls.Data;
using MvcBowls.Models;

namespace MvcBowls.Controllers
{
    public class BowlsController : Controller
    {
        private readonly MvcBowlsContext _context;

        public BowlsController(MvcBowlsContext context)
        {
            _context = context;
        }

        // GET: Bowls
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bowl.ToListAsync());
        }

        // GET: Bowls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bowl = await _context.Bowl
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bowl == null)
            {
                return NotFound();
            }

            return View(bowl);
        }

        // GET: Bowls/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bowls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,VarietyOfBowls,Color,Material,Uses,Price,Rating")] Bowl bowl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bowl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bowl);
        }

        // GET: Bowls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bowl = await _context.Bowl.FindAsync(id);
            if (bowl == null)
            {
                return NotFound();
            }
            return View(bowl);
        }

        // POST: Bowls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,VarietyOfBowls,Color,Material,Uses,Price,Rating")] Bowl bowl)
        {
            if (id != bowl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bowl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BowlExists(bowl.Id))
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
            return View(bowl);
        }

        // GET: Bowls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bowl = await _context.Bowl
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bowl == null)
            {
                return NotFound();
            }

            return View(bowl);
        }

        // POST: Bowls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bowl = await _context.Bowl.FindAsync(id);
            _context.Bowl.Remove(bowl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BowlExists(int id)
        {
            return _context.Bowl.Any(e => e.Id == id);
        }
    }
}
