using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SimCa_Web.Data;
using SimCa_Web.Models.Cadastro;

namespace SimCa_Web.Controllers
{
    public class CadastroCategoriaController : Controller
    {
        private readonly SimCaContext _context;

        public CadastroCategoriaController(SimCaContext context)
        {
            _context = context;
        }

        // GET: CadastroCategoria
        public async Task<IActionResult> Index()
        {
            return View(await _context.CadastroCategoria.ToListAsync());
        }

        // GET: CadastroCategoria/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastroCategoria = await _context.CadastroCategoria
                .FirstOrDefaultAsync(m => m.CategoriaId == id);
            if (cadastroCategoria == null)
            {
                return NotFound();
            }

            return View(cadastroCategoria);
        }

        // GET: CadastroCategoria/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CadastroCategoria/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoriaId,Categoria")] CadastroCategoria cadastroCategoria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cadastroCategoria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cadastroCategoria);
        }

        // GET: CadastroCategoria/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastroCategoria = await _context.CadastroCategoria.FindAsync(id);
            if (cadastroCategoria == null)
            {
                return NotFound();
            }
            return View(cadastroCategoria);
        }

        // POST: CadastroCategoria/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategoriaId,Categoria")] CadastroCategoria cadastroCategoria)
        {
            if (id != cadastroCategoria.CategoriaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cadastroCategoria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastroCategoriaExists(cadastroCategoria.CategoriaId))
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
            return View(cadastroCategoria);
        }

        // GET: CadastroCategoria/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastroCategoria = await _context.CadastroCategoria
                .FirstOrDefaultAsync(m => m.CategoriaId == id);
            if (cadastroCategoria == null)
            {
                return NotFound();
            }

            return View(cadastroCategoria);
        }

        // POST: CadastroCategoria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cadastroCategoria = await _context.CadastroCategoria.FindAsync(id);
            _context.CadastroCategoria.Remove(cadastroCategoria);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadastroCategoriaExists(int id)
        {
            return _context.CadastroCategoria.Any(e => e.CategoriaId == id);
        }
    }
}
