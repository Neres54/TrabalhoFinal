#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrabalhoFinal.Models;

namespace TrabalhoFinal.Controllers
{
    public class TipoDePagamnetosController : Controller
    {
        private readonly MyDbContext _context;

        public TipoDePagamnetosController(MyDbContext context)
        {
            _context = context;
        }

        // GET: TipoDePagamnetos
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoDePagamneto.ToListAsync());
        }

        // GET: TipoDePagamnetos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoDePagamneto = await _context.TipoDePagamneto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoDePagamneto == null)
            {
                return NotFound();
            }

            return View(tipoDePagamneto);
        }

        // GET: TipoDePagamnetos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoDePagamnetos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeDocobrado,InformacoesAdicionais")] TipoDePagamneto tipoDePagamneto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoDePagamneto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoDePagamneto);
        }

        // GET: TipoDePagamnetos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoDePagamneto = await _context.TipoDePagamneto.FindAsync(id);
            if (tipoDePagamneto == null)
            {
                return NotFound();
            }
            return View(tipoDePagamneto);
        }

        // POST: TipoDePagamnetos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeDocobrado,InformacoesAdicionais")] TipoDePagamneto tipoDePagamneto)
        {
            if (id != tipoDePagamneto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoDePagamneto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoDePagamnetoExists(tipoDePagamneto.Id))
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
            return View(tipoDePagamneto);
        }

        // GET: TipoDePagamnetos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoDePagamneto = await _context.TipoDePagamneto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoDePagamneto == null)
            {
                return NotFound();
            }

            return View(tipoDePagamneto);
        }

        // POST: TipoDePagamnetos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoDePagamneto = await _context.TipoDePagamneto.FindAsync(id);
            _context.TipoDePagamneto.Remove(tipoDePagamneto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoDePagamnetoExists(int id)
        {
            return _context.TipoDePagamneto.Any(e => e.Id == id);
        }
    }
}
