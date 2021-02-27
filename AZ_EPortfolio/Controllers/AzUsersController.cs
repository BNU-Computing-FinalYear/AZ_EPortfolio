using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AZ_EPortfolio.Data;
using AZ_EPortfolio.Models;
using System.Security.Claims;

namespace AZ_EPortfolio.Controllers
{
    public class AzUsersController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AzUsersController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            //Fetching Id of user that is logged in
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            //and passing all the application user except the loggin user view
            return View(await _db.ApplicationUser.Where(u => u.Id != claim.Value).ToListAsync());
        }

        public async Task<IActionResult> Lock(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Returns the first object. If not found, returns null
            var applicationUser = await _db.ApplicationUser.FirstOrDefaultAsync(m => m.Id == id);

            if (applicationUser == null)
            {
                return NotFound();
            }

            applicationUser.LockoutEnd = DateTime.Now.AddYears(1000);

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        //// GET: AzUsers
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _db.AzUser.ToListAsync());
        //}

        // GET: AzUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var azUser = await _db.AzUser
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
                _db.Add(azUser);
                await _db.SaveChangesAsync();
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

            var azUser = await _db.AzUser.FindAsync(id);
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
                    _db.Update(azUser);
                    await _db.SaveChangesAsync();
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

            var azUser = await _db.AzUser
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
            var azUser = await _db.AzUser.FindAsync(id);
            _db.AzUser.Remove(azUser);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AzUserExists(int id)
        {
            return _db.AzUser.Any(e => e.AzUserId == id);
        }
    }
}
