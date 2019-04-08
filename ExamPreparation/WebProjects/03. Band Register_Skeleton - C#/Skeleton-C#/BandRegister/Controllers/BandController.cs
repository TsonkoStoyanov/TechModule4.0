using System.Linq;
using BandRegister.Data;
using BandRegister.Models;
using Microsoft.AspNetCore.Mvc;

namespace BandRegister.Controllers
{
    public class BandController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new BandsDbContext())
            {
                var bands = db.Bands.ToList();

                return View(bands);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(Band band)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            using (var db = new BandsDbContext())
            {
                db.Bands.Add(band);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new BandsDbContext())
            {
                var bandsToEdit = db.Bands.FirstOrDefault(b => b.Id == id);


                if (bandsToEdit == null)
                {
                    return RedirectToAction("Index");
                }

                return this.View(bandsToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Band band)
        {
            using (var db = new BandsDbContext())
            {
                db.Bands.Update(band);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new BandsDbContext())
            {
                var bandsToDelete = db.Bands.FirstOrDefault(b => b.Id == id);


                if (bandsToDelete == null)
                {
                    return RedirectToAction("Index");
                }

                return this.View(bandsToDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Band band)
        {
            using (var db = new BandsDbContext())
            {
                db.Bands.Remove(band);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}