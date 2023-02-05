using FinalTUFOD.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalTUFOD.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index() // admin paneli anasayfası
        {
            var variable = c.HomePages.ToList(); // listeleme işlemi veritabanı için
            return View(variable);
        }
        public ActionResult GoToHomePage(int id) // güncelleme işlemleri için verinin bulunmasını sağlayacak fonksiyon
        { // id'ye göre arama yapar
            var gth = c.HomePages.Find(id);
            return View("GoToHomePage", gth);
        }
        public ActionResult UpdateHomePage(HomePage x)
        {
            var hp = c.HomePages.Find(x.id);
            hp.name = x.name; // veritabanındaki nesne ile eklediğim nesneyi değiştirir/üzerine yazar.
            hp.content = x.content;
            hp.newshead = x.newshead;
            hp.contant = x.contant;
            hp.news1head = x.news1head;
            hp.news2head = x.news2head;
            hp.news3head = x.news3head;
            hp.news4head = x.news4head;
            hp.news1 = x.news1;
            hp.news2 = x.news2;
            hp.news3 = x.news3;
            hp.news4 = x.news4;
            c.SaveChanges(); // kaydeder
            return RedirectToAction("Index"); // anasayfaya yönlendirir
        }
        public ActionResult iconList() // ikonları listelememizi sağlayan fonksiyon
        {
            var variable = c.icons.ToList();
            return View(variable);
        }
        [HttpGet]
        public ActionResult newIcon()
        {
            return View();
        }
        [HttpPost]
        public ActionResult newIcon(Icons p)
        {
            c.icons.Add(p); // yeni ikon ekleyip kaydedip ikon anasayfasına gönderen komutlar
            c.SaveChanges();
            return RedirectToAction("iconList");
        }
        public ActionResult GoToIcon(int id) // güncelleme işlemleri için verinin bulunmasını sağlayacak fonksiyon
        { // id'ye göre arama yapar
            var gti = c.icons.Find(id);
            return View("GoToIcon", gti);
        }
        public ActionResult UpdateIcon(Icons x)
        { // id'ye göre bulunan ikonun üzerine yeni ikon ve linkini ekleyip kaydedip ikon anasayfasına yönlendiren komutlar
            var ic = c.icons.Find(x.id);
            ic.icon = x.icon;
            ic.link = x.link;
            c.SaveChanges();
            return RedirectToAction("iconList");
        }
        public ActionResult DeleteIcon(int id)
        {
            var di = c.icons.Find(id); // id'ye göre buluyor
            c.icons.Remove(di); // siliyor
            c.SaveChanges(); // kaydediyor
            return RedirectToAction("iconList"); // ikon sayfasına yönlendiriyor
        }
    }
}