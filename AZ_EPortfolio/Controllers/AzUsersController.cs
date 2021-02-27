using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AZ_EPortfolio.Data;
using AZ_EPortfolio.Models;

namespace AZ_EPortfolio.Controllers
{
    [Area("Admin")]
    public class AzUsersController : Controller
    {
        private readonly ApplicationDbContext _db;

        private readonly ApplicationDbContext _context;

        public AzUsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AzUsers
        public async Task<IActionResult> Index()
        {
            return View(await _context.AzUser.ToListAsync());
        }

        // GET: AzUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var azUser = await _context.AzUser
                .FirstOrDefaultAsync(m => m.AzUserId == id);
            if (azUser == null)
            {
                return NotFound();
            }

            return View(azUser);
        }

        // GET: AzUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AzUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AzUserId,UserId,FirstName,LastName,Email,EmploymentStatus,UserType,MobileNo")] AzUser azUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(azUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(azUser);
        }

        // GET: AzUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var azUser = await _context.AzUser.FindAsync(id);
            if (azUser == null)
            {
                return NotFound();
            }
            return View(azUser);
        }

        // POST: AzUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AzUserId,UserId,FirstName,LastName,Email,EmploymentStatus,UserType,MobileNo")] AzUser azUser)
        {
            if (id != azUser.AzUserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(azUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AzUserExists(azUser.AzUserId))
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
            return View(azUser);
        }

        // GET: AzUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var azUser = await _context.AzUser
                .FirstOrDefaultAsync(m => m.AzUserId == id);
            if (azUser == null)
            {
                return NotFound();
            }

            return View(azUser);
        }

        // POST: AzUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var azUser = await _context.AzUser.FindAsync(id);
            _context.AzUser.Remove(azUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AzUserExists(int id)
        {
            return _context.AzUser.Any(e => e.AzUserId == id);
        }
    }
}
