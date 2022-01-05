using Microsoft.AspNetCore.Mvc;
using MVC_Vaje202122_Priprava.Data;
using MVC_Vaje202122_Priprava.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Vaje202122_Priprava.Controllers
{

    public class KategorijaController : Controller
    {
        private AppDbContext _db;

        public KategorijaController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Kategorija> objKategorijaList = _db.Kategorije.ToList();

            return View(objKategorijaList);
        }



        //CREATE
        //GET
        public IActionResult Create()
        {
            Kategorija obj = new Kategorija();
            return View(obj);
        }


        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Kategorija obj)
        {
            if (obj.naziv == obj.vrstniRed.ToString())
            {
                ModelState.AddModelError("CustomError", "Splosna napaka: Naziv ne sme biti enak vrstnemu redu!");

                ModelState.AddModelError("naziv", "Naziv ne sme biti enak vrstnemu redu!");

            }

            if (obj.naziv.Length <= 3)
            {
                ModelState.AddModelError("CustomError", "Naziv mora biti dalši od 3 znakov!");
                TempData["error"] = "Zapis ni bil dodan!";

            }

            //Server Side Validation
            //preverimo veljavnost (če ni veljaven, vrnemo podatke nazaj)
            if (ModelState.IsValid)
            {
                _db.Kategorije.Add(obj);
                _db.SaveChanges();
                //TempData
                TempData["success"] = "Kategorija uspešno ustvarjena!";

                return RedirectToAction("Index");
            }
            return View(obj);
        }





        //EDIT
        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Kategorije.Find(id);
            //primer 2
            // var obj = _db.Kategorije.FirstOrDefault(a => a.Id == id);
            //var obj2 = _db.Kategorije.SingleOrDefault(a => a.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }


        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Kategorija obj)
        {
            if (obj.naziv == obj.vrstniRed.ToString())
            {
                ModelState.AddModelError("CustomError", "Splosna napaka: Naziv ne sme biti enak vrstnemu redu!");

                ModelState.AddModelError("naziv", "Naziv ne sme biti enak vrstnemu redu!");

            }

            //Server Side Validation
            //preverimo veljavnost (če ni veljaven, vrnemo podatke nazaj)
            if (ModelState.IsValid)
            {
                //sprememba iz Add v Update
                _db.Kategorije.Update(obj);
                _db.SaveChanges();

                TempData["success"] = "Kategorija uspešno posodobljena!";

                return RedirectToAction("Index");
            }
            return View(obj);
        }




        //EDIT
        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Kategorije.Find(id);
            //primer 2
            // var obj = _db.Kategorije.FirstOrDefault(a => a.Id == id);
            //var obj2 = _db.Kategorije.SingleOrDefault(a => a.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }


        //POST
        //[HttpPost,ActionName("Delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {

            var obj = _db.Kategorije.Find(id);

            if (obj == null)
            {
                return NotFound();
            }


            //sprememba iz Update v Remove
            _db.Kategorije.Remove(obj);
            _db.SaveChanges();

            TempData["success"] = "Kategorija uspešno odstranjena!";

            return RedirectToAction("Index");

        }
    }
}
