using System;
using System.Collections.Generic;
using System.Linq;
using GameStore.Data;
using GameStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new GameDbContext())
            {
                var games = db.Games.ToList();

                return this.View(games);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(Game game)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            using (var db = new GameDbContext())
            {
                db.Games.Add(game);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new GameDbContext())
            {
                var gameToEdit = db.Games.FirstOrDefault(b => b.Id == id);


                if (gameToEdit == null)
                {
                    return RedirectToAction("Index");
                }

                return this.View(gameToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Game game)
        {
            using (var db = new GameDbContext())
            {
                db.Games.Update(game);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new GameDbContext())
            {
                var gameToDelete = db.Games.FirstOrDefault(b => b.Id == id);


                if (gameToDelete == null)
                {
                    return RedirectToAction("Index");
                }

                return this.View(gameToDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Game game)
        {
            using (var db = new GameDbContext())
            {
                db.Games.Remove(game);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}