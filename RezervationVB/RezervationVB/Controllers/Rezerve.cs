using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RezervationVB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RezervationVB.Controllers
{
    public class Rezerve : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var deger = c.TableRezerve.ToList();
            //Include(x => x.masa)
            return View(deger);
        }

        [HttpGet]
        public IActionResult RezervasyonEkle()
        {
            List<SelectListItem> deger1 = (from x in c.TableMasa.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.masaetiketi,
                                               Value = x.masaid.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;

            //true değerleri döndür

            return View();
        }

        [HttpPost]

        public IActionResult RezervasyonEkle(rezerve r)
        {

            //c.TableRezerve.Add(r);
            //c.SaveChanges();
            //return RedirectToAction("Index");

            var desk = c.TableMasa.Where(x => x.masaid == r.masaid).First();
            r.masa = desk;
            c.TableRezerve.Add(r);
            c.SaveChanges();
            return RedirectToAction("Index");
            
        }
    

        public IActionResult RezerveSil(int id)
        {
            var reze = c.TableRezerve.Find(id);
            c.TableRezerve.Remove(reze);
            c.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult RezerveGetir(int id)
        {
            var rzve = c.TableRezerve.Find(id);
            List<SelectListItem> deger1 = (from x in c.TableMasa.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.masaetiketi,
                                               Value = x.masaid.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;

            return View("RezerveGetir", rzve);

            //List<SelectListItem> deger2 = (from x in c.TableMasa.ToList()
            //                               select new SelectListItem
            //                               {
            //                                   Text = x.masaetiketi,
            //                                   Value = x.masaid.ToString()
            //                               }).ToList();
            //ViewBag.dgr2 = deger2;
            //return View();



        }
        [HttpPost]

        public IActionResult RezerveGuncelle(rezerve z)
        {

            var rezar = c.TableRezerve.Find(z.rezerveid);
            rezar.sicilno = z.sicilno;
            rezar.kullaniciadi = z.kullaniciadi;
            rezar.rezervebaslangic = z.rezervebaslangic;
            rezar.rezervebitis = z.rezervebitis;
            var desk = c.TableMasa.Where(x => x.masaid == z.masaid).First();
            rezar.masaid = desk.masaid;
            c.SaveChanges();
            return RedirectToAction("Index");

            //var ret = c.TRezerve.Find(z.rezerveid);
            //ret.rezerveid = z.rezerveid;
            //ret.sicilno = z.sicilno;
            //ret.kullaniciadi = z.kullaniciadi;
            //ret.masa.masaetiketi = z.masa.masaetiketi;
            //ret.rezervebaslangic = z.rezervebaslangic;
            //ret.rezervebitis = z.rezervebitis;
            //c.SaveChanges();
            //return RedirectToAction("Index");


            //c.TableRezerve.Update(z);
            //c.SaveChanges();
            //return RedirectToAction("Index");


        }

    }
}
