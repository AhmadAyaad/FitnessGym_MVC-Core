using FitnessGym.Infrastructure.Repository;
using FitnessGym.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessGym.Web.Controllers
{
    public class CoachController : Controller
    {
        readonly IRepository<Coach> _coachReposiotry;

        public CoachController(IRepository<Coach> coachReposiotry)
        {
            _coachReposiotry = coachReposiotry;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _coachReposiotry.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Coach coach)
        {
            //if (ModelState.IsValid)
            //{
                try
                {
                    await _coachReposiotry.Create(coach);
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    Trace.WriteLine(e.Message);
                }
            //}
            return View();
        }
    }
}
