using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FootballPools.Web.Data;
using FootballPools.Web.Data.Entities;

namespace FootballPools.Web.Controllers
{
    public class TeamsController : Controller
    {
        private readonly DataContext _context;

        public TeamsController(DataContext context)
        {
            _context = context;
        }

        // GET: Teams
        public async Task<IActionResult> Index()
        {
            return View(await _context.Teams.ToListAsync());
        }

        // GET: Teams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamEntity = await _context.Teams
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teamEntity == null)
            {
                return NotFound();
            }

            return View(teamEntity);
        }

        // GET: Teams/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Teams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeamEntity teamEntity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teamEntity);
                try
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    if(ex.InnerException.Message.Contains("duplicate"))
                    {
                        ModelState.AddModelError(string.Empty, "Already exist a team with the same name.");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, ex.InnerException.Message);
                    }

                }

                
            }
            return View(teamEntity);
        }

        // GET: Teams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamEntity = await _context.Teams.FindAsync(id);
            if (teamEntity == null)
            {
                return NotFound();
            }
            return View(teamEntity);
        }

        // POST: Teams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TeamEntity teamEntity)
        {
            if (id != teamEntity.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Add(teamEntity);
                try
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                 catch (Exception ex)
                {
                    if (ex.InnerException.Message.Contains("identity"))
                    {
                        ModelState.AddModelError(string.Empty, $"Already exist a team : {teamEntity.Name}.");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, ex.InnerException.Message);
                    }

                }
            }
            return View(teamEntity);
        }

        // GET: Teams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamEntity = await _context.Teams
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teamEntity == null)
            {
                return NotFound();
            }

            _context.Teams.Remove(teamEntity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
