using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using eCommerce_Website.Data;
using eCommerce_Website.Models;

namespace eCommerce_Website.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductTypesController : Controller
    {
        private ApplicationDbContext _db;

        public ProductTypesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.ProductTypes.ToList());
        }

        //GET Create Action Method

        public ActionResult Create()
        {
            return View();
        }



        //Post Create Action Method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductTypes categoryTypes)
        {
            if(ModelState.IsValid)
            {
                _db.ProductTypes.Add(categoryTypes);
                await _db.SaveChangesAsync();
                TempData["save"] = "Product type has been saved";
                return RedirectToAction(nameof(Index));
            }
            return View(categoryTypes);
        }


        //Get Edit Action Method

        public ActionResult Edit(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }
            var categoryType = _db.ProductTypes.Find(id);
            if (categoryType == null)
            {
                return NotFound();
            }
            return View(categoryType);
        }

        //Post Edit Action Method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductTypes categoryTypes)
        {
            if (ModelState.IsValid)
            {
                _db.Update(categoryTypes);
                await _db.SaveChangesAsync();
                TempData["edit"] = "Product type has been updated";
                return RedirectToAction(nameof(Index));
            }
            return View(categoryTypes);
        }


        //Get Details Action Method

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var categoryType = _db.ProductTypes.Find(id);
            if (categoryType == null)
            {
                return NotFound();
            }
            return View(categoryType);
        }

        //Post Details Action Method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(ProductTypes categoryTypes)
        {
            return RedirectToAction(nameof(Index));

        }


        //Get Delete Action Method

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var categoryType = _db.ProductTypes.Find(id);
            if (categoryType == null)
            {
                return NotFound();
            }
            return View(categoryType);
        }

        //Post Delete Action Method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, ProductTypes categoryTypes)
        {
            if(id==null)
            {
                return NotFound();
            }

            if (id!=categoryTypes.Id)
            {
                return NotFound();
            }

            var categoryType = _db.ProductTypes.Find(id);
            if (categoryType == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Remove(categoryType);
                await _db.SaveChangesAsync();
                TempData["delete"] = "Product type has been deleted";
                return RedirectToAction(nameof(Index));
            }
            return View(categoryTypes);
        }

    }
}
