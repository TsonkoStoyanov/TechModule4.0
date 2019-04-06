using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new LibraryDbContext())
            {
                var books = db.Books.ToList();

                return View(books);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(string title, string author, decimal price)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
            {
                return RedirectToAction("Index");
            }

            Book book = new Book()
            {
                Title = title,
                Author = author,
                Price = price
            };


            using (var db = new LibraryDbContext())
            {
                db.Books.Add(book);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new LibraryDbContext())
            {
                var bookToEdit = db.Books.FirstOrDefault(b => b.Id == id);


                if (bookToEdit == null)
                {
                    return RedirectToAction("Index");
                }

                return this.View(bookToEdit);
            }

        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            using (var db = new LibraryDbContext())
            {
                db.Books.Update(book);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new LibraryDbContext())
            {
                var bookToDelete = db.Books.FirstOrDefault(b => b.Id == id);


                if (bookToDelete == null)
                {
                    return RedirectToAction("Index");
                }

                return this.View(bookToDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
            using (var db = new LibraryDbContext())
            {
                db.Books.Remove(book);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}