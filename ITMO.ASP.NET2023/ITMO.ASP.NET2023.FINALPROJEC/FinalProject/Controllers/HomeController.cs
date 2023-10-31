using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FinalContext db;

        public HomeController(ILogger<HomeController> logger, FinalContext context)
        {
            _logger = logger;
            db = context;
        }
        private void GiveStudents()
        {
            var allStudents = db.Students.ToList<Student>();
            ViewBag.Students = allStudents;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //Функция вычисления суммы оценок
        public async Task<ActionResult> StudentStatistics()
        {
            IQueryable<SuccessModel> data =
                                           from grade in db.Grades
                                           group grade by grade.StudentId into IdGroup
                                           select new SuccessModel()
                                            {
                                                StudentId = IdGroup.Key,
                                                FullName = (
                                                            from student in db.Students
                                                            where student.StudentId == IdGroup.Key
                                                            select student.FullName).Single(),
                                                CountGrade = IdGroup.Count(),
                                                SumGrade = (
                                                            from grade2 in IdGroup
                                                            select grade2.Score).Sum()
                                           };

            return View(await data.AsNoTracking().ToListAsync());
        }

        public async Task<ActionResult> Top()
        {
            IQueryable<SuccessModel> data =
                                           from grade in db.Grades
                                           group grade by grade.StudentId into IdGroup
                                           select new SuccessModel()
                                           {
                                               StudentId = IdGroup.Key,
                                               FullName = (
                                                            from student in db.Students
                                                            where student.StudentId == IdGroup.Key
                                                            select student.FullName).Single(),
                                               CountGrade = IdGroup.Count(),
                                               SumGrade = (
                                                            from grade2 in IdGroup
                                                            select grade2.Score).Sum()
                                           };

            data = from dt in data
                   orderby dt.SumGrade descending
                   select dt;


            return View(await data.Take(5).AsNoTracking().ToListAsync());
        }

        public async Task<ActionResult> AntiTop()
        {
            IQueryable<SuccessModel> data =
                                           from grade in db.Grades
                                           group grade by grade.StudentId into IdGroup
                                           select new SuccessModel()
                                           {
                                               StudentId = IdGroup.Key,
                                               FullName = (
                                                            from student in db.Students
                                                            where student.StudentId == IdGroup.Key
                                                            select student.FullName).Single(),
                                               CountGrade = IdGroup.Count(),
                                               SumGrade = (
                                                            from grade2 in IdGroup
                                                            select grade2.Score).Sum()
                                           };

            data = from dt in data
                   orderby dt.SumGrade
                   select dt;

            return View(await data.Take(5).AsNoTracking().ToListAsync());
        }
    }
}