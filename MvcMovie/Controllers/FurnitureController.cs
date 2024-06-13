using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Furniture.Data;
using Furniture.Models;

namespace SpringFurniture.Controllers
{
    public class FurnitureController : Controller
    {
        private readonly SpringFurnitureContext _context;

        public FurnitureController(SpringFurnitureContext context)
        {
            _context = context;
        }

        // GET: Furniture
        public async Task<IActionResult> Index(string furnitureModel, string searchString)
        {
            if (_context.Furniture == null)
            {
                return Problem("Entity set 'SpringFurnitureContext.Furniture'  is null.");
            }

            // Use LINQ to get list of types.
            IQueryable<string> genreQuery = from m in _context.Furniture
                                            orderby m.Type
                                            select m.Type;
            var furniture = from m in _context.Furniture
                         select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                furniture = furniture.Where(s => s.Name!.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(movieGenre))
            {
                furniture = furniture.Where(x => x.Type == furnitureType);
            }

            var furnitureTypeVM = new FurnitureTypeViewModel
            {
                Type = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Furniture = await furniture.ToListAsync()
            };

            return View(movieGenreVM);
        }

        // GET: Furniture/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Furniture == null)
            {
                return NotFound();
            }

            var furniture = await _context.Furniture
                .FirstOrDefaultAsync(m => m.Id == id);
            if (furniture == null)
            {
                return NotFound();
            }

            return View(furniture);
        }

        // GET: Furniture/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Furniture/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Colour,Type,Price,Rating")] Furniture furniture)
        {
            if (ModelState.IsValid)
            {
                _context.Add(furniture);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(furniture);
        }

        // GET: Furniture/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Furniture == null)
            {
                return NotFound();
            }

            var furniture = await _context.Furniture.FindAsync(id);
            if (furniture == null)
            {
                return NotFound();
            }
            return View(furniture);
        }

        // POST: Furniture/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Colour,Type,Price,Rating")] Movie movie)
        {
            if (id != furniture.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(furniture);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FurnitureExists(furniture.Id))
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
            return View(furniture);
        }

        // GET: Furniture/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Furniture == null)
            {
                return NotFound();
            }

            var furniture = await _context.Furniture
                .FirstOrDefaultAsync(m => m.Id == id);
            if (furniture == null)
            {
                return NotFound();
            }

            return View(furniture);
        }

        // POST: Furniture/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Furniture == null)
            {
                return Problem("Entity set 'SpringFurnitureContext.Furniture'  is null.");
            }
            var furniture = await _context.Furniture.FindAsync(id);
            if (furniture != null)
            {
                _context.Furniture.Remove(movie);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FurnitureExists(int id)
        {
          return (_context.Furniture?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
