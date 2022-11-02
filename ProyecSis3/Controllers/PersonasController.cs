using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyecSis3.Models;

namespace ProyecSis3.Controllers
{
    public class PersonasController : Controller
    {
        private readonly ProyectoSI3Context _context;

        public PersonasController(ProyectoSI3Context context)
        {
            _context = context;
        }

        // GET: Personas
        public async Task<IActionResult> Index()
        {
            var proyectoSI3Context = _context.Personas.Include(p => p.CatCorreoIdCatCorreoNavigation).Include(p => p.CatDireccionIdCatDireccionNavigation).Include(p => p.CatTelefonoIdCatTelefonoNavigation).Include(p => p.UsuarioIdUsuarioNavigation);
            return View(await proyectoSI3Context.ToListAsync());
        }

        // GET: Personas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Personas == null)
            {
                return NotFound();
            }

            var persona = await _context.Personas
                .Include(p => p.CatCorreoIdCatCorreoNavigation)
                .Include(p => p.CatDireccionIdCatDireccionNavigation)
                .Include(p => p.CatTelefonoIdCatTelefonoNavigation)
                .Include(p => p.UsuarioIdUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.IdPersona == id);
            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        // GET: Personas/Create
        public IActionResult Create()
        {
            ViewData["CatCorreoIdCatCorreo"] = new SelectList(_context.CatCorreos, "IdCatCorreo", "IdCatCorreo");
            ViewData["CatDireccionIdCatDireccion"] = new SelectList(_context.CatDireccions, "IdCatDireccion", "IdCatDireccion");
            ViewData["CatTelefonoIdCatTelefono"] = new SelectList(_context.CatTelefonos, "IdCatTelefono", "IdCatTelefono");
            ViewData["UsuarioIdUsuario"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario");
            return View();
        }

        // POST: Personas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPersona,Nombre,Apellido1,Apellido2,UsuarioIdUsuario,CatTelefonoIdCatTelefono,CatCorreoIdCatCorreo,CatDireccionIdCatDireccion")] Persona persona)
        {
            if (ModelState.IsValid)
            {
                _context.Add(persona);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CatCorreoIdCatCorreo"] = new SelectList(_context.CatCorreos, "IdCatCorreo", "IdCatCorreo", persona.CatCorreoIdCatCorreo);
            ViewData["CatDireccionIdCatDireccion"] = new SelectList(_context.CatDireccions, "IdCatDireccion", "IdCatDireccion", persona.CatDireccionIdCatDireccion);
            ViewData["CatTelefonoIdCatTelefono"] = new SelectList(_context.CatTelefonos, "IdCatTelefono", "IdCatTelefono", persona.CatTelefonoIdCatTelefono);
            ViewData["UsuarioIdUsuario"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario", persona.UsuarioIdUsuario);
            return View(persona);
        }

        // GET: Personas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Personas == null)
            {
                return NotFound();
            }

            var persona = await _context.Personas.FindAsync(id);
            if (persona == null)
            {
                return NotFound();
            }
            ViewData["CatCorreoIdCatCorreo"] = new SelectList(_context.CatCorreos, "IdCatCorreo", "IdCatCorreo", persona.CatCorreoIdCatCorreo);
            ViewData["CatDireccionIdCatDireccion"] = new SelectList(_context.CatDireccions, "IdCatDireccion", "IdCatDireccion", persona.CatDireccionIdCatDireccion);
            ViewData["CatTelefonoIdCatTelefono"] = new SelectList(_context.CatTelefonos, "IdCatTelefono", "IdCatTelefono", persona.CatTelefonoIdCatTelefono);
            ViewData["UsuarioIdUsuario"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario", persona.UsuarioIdUsuario);
            return View(persona);
        }

        // POST: Personas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPersona,Nombre,Apellido1,Apellido2,UsuarioIdUsuario,CatTelefonoIdCatTelefono,CatCorreoIdCatCorreo,CatDireccionIdCatDireccion")] Persona persona)
        {
            if (id != persona.IdPersona)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(persona);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonaExists(persona.IdPersona))
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
            ViewData["CatCorreoIdCatCorreo"] = new SelectList(_context.CatCorreos, "IdCatCorreo", "IdCatCorreo", persona.CatCorreoIdCatCorreo);
            ViewData["CatDireccionIdCatDireccion"] = new SelectList(_context.CatDireccions, "IdCatDireccion", "IdCatDireccion", persona.CatDireccionIdCatDireccion);
            ViewData["CatTelefonoIdCatTelefono"] = new SelectList(_context.CatTelefonos, "IdCatTelefono", "IdCatTelefono", persona.CatTelefonoIdCatTelefono);
            ViewData["UsuarioIdUsuario"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario", persona.UsuarioIdUsuario);
            return View(persona);
        }

        // GET: Personas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Personas == null)
            {
                return NotFound();
            }

            var persona = await _context.Personas
                .Include(p => p.CatCorreoIdCatCorreoNavigation)
                .Include(p => p.CatDireccionIdCatDireccionNavigation)
                .Include(p => p.CatTelefonoIdCatTelefonoNavigation)
                .Include(p => p.UsuarioIdUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.IdPersona == id);
            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        // POST: Personas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Personas == null)
            {
                return Problem("Entity set 'ProyectoSI3Context.Personas'  is null.");
            }
            var persona = await _context.Personas.FindAsync(id);
            if (persona != null)
            {
                _context.Personas.Remove(persona);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonaExists(int id)
        {
          return _context.Personas.Any(e => e.IdPersona == id);
        }
    }
}
