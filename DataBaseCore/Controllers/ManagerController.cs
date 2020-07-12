using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataBaseCore.Data;
using DataBaseCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace DataBaseCore.Controllers
{
   
    public class ManagerController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public ManagerController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult AddColor()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddColor( Color color)
        {
            _dbContext.ColorTab.Add(color);
            _dbContext.SaveChanges();
            return RedirectToAction ("ListColor");
        }
        public IActionResult ListColor()
        {
            var result = _dbContext.ColorTab;
            return View(result);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            ViewBag.Supplier = new SelectList(_dbContext.SupplierTb.ToList(), "Id", "Name");
            ViewBag.Color = new SelectList(_dbContext.ColorTab.ToList(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct (Product product)
        {
            //ViewBag.Resource = new SelectList(_userManager.Users.ToList(), "Id", "Name")
           
            _dbContext.ProductTb.Add(product);
            _dbContext.SaveChanges();
            return RedirectToAction("ProductList");
        }


       
        public IActionResult ProductList()
        {
            var product = _dbContext.ProductTb.Include(x => x.Supplier).Include(m => m.Color).ToList();

            return View(product);
        }

       

        [HttpGet]
        public IActionResult AddSupplier()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSupplier(Supplier supplier)
        {
            //ViewBag.Resource = new SelectList(_userManager.Users.ToList(), "Id", "Name")

            _dbContext.SupplierTb.Add(supplier);
            _dbContext.SaveChanges();
            return View (); /*RedirectToAction ("ProductList");*/
        }

        public IActionResult SupplierList()
        {
            IEnumerable <Supplier> supplier = _dbContext.SupplierTb.Include(x => x.Products).ThenInclude(m => m.Color).ToList();
            return View(supplier);
        }

    }
}
