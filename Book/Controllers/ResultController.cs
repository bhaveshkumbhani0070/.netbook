using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book.Models;
using Microsoft.AspNetCore.Mvc;

namespace Book.Controllers
{
    public class ResultController : Controller
    {
        private static List<ResultViewModel> resultViewModels = new();
        private static int nextId = 1;

        public IActionResult Index()
        {
            return View(resultViewModels);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        public IActionResult Create(ResultViewModel resultViewModel)
        {
            resultViewModel.Id = nextId++;
            resultViewModels.Add(resultViewModel);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var markSheet = resultViewModels.FirstOrDefault(m => m.Id == id);
            return markSheet == null ? NotFound() : View(markSheet);
        }

        [HttpPost]
        public IActionResult Edit(ResultViewModel resultViewModel)
        {
            var existingMarkSheet = resultViewModels.FirstOrDefault(m => m.Id == resultViewModel.Id);
            if (existingMarkSheet == null)
            {
                return NotFound();
            }


            existingMarkSheet.StudentName = resultViewModel.StudentName;
            existingMarkSheet.MathMarks = resultViewModel.MathMarks;
            existingMarkSheet.ScienceMarks = resultViewModel.ScienceMarks;
            existingMarkSheet.EnglishMarks = resultViewModel.EnglishMarks;

            return RedirectToAction("Index");
        }


    }
}

