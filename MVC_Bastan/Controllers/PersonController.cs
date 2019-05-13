using MVC_Bastan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Bastan.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            PersonModel model = new PersonModel();
            model.Name = "Hasan Mesut Alkan";
            model.BirthDate = new DateTime(1987,11,01);

            model.GsmNumberList = new List<string>();
            model.GsmNumberList.Add("5553131313");
            model.GsmNumberList.Add("5302437272");

            model.AddressList = new List<string>();
            model.AddressList.Add("Bakırköy Bilge Adam Şubesi");
            model.AddressList.Add("Ataşehir'in bi mahallesi");

            return View(model);
        }
    }
}