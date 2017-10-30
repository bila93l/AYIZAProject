//using AYIZAProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AYIZAProject.Controllers
{
    public class LanguageController : Controller
    {
        // GET: Language
       // AYIZA_DBEntities7 objDb = new AYIZA_DBEntities7();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public  ActionResult Create()
        {
            return View();
        }
        // [HttpPost]
        //public ActionResult Create()
        // {

        //     language.AY_ENV_ID.ToString();
        //     language.AY_F_CREATED_BY.ToString();
        //     language.AY_F_CREATE_DATE.ToString();
        //     language.AY_F_CREATE_TIME.ToString();
        //     language.AY_F_LANG_CODE.ToString();
        //     language.AY_F_LANG_TEXT.ToString();
        //     language.AY_F_LAST_CHG_BY.ToString();
        //     language.AY_F_LAST_CHG_DATE.ToString();
        //     language.AY_F_LAST_CNG_TIME.ToString();

        //     objDb.Languages.Add(language);
        //     objDb.SaveChanges();
        //     ModelState.Clear();
        //     language = null;
        //     return View();
        // }


        //[HttpGet]
        //public ActionResult List()
        //{

        //    return View(objDb.Languages.ToList());
        //}

        //[HttpGet]
        //public ActionResult Edit(int Id)
        //{       
                
        //    return View(objDb.Languages.Find(Id));
        //}

        //[HttpPost]
        //public ActionResult Edit(Language language, int Id)
        //{

        //    Language language1 = objDb.Languages.Find(Id);

        //    language1.AY_F_CREATED_BY = language.AY_F_CREATED_BY.ToString();
        //    language1.AY_F_LANG_TEXT = language.AY_F_LANG_TEXT.ToString();
        //    language1.AY_F_LAST_CHG_BY = language.AY_F_LAST_CHG_BY.ToString();
        //    language1.AY_F_LAST_CHG_DATE = language.AY_F_LAST_CHG_DATE.ToString();
        //    language1.AY_F_LAST_CNG_TIME = language.AY_F_LAST_CNG_TIME.ToString();


        //    objDb.Entry(language1).State = System.Data.Entity.EntityState.Modified;
        //    objDb.SaveChanges();

        //    return RedirectToAction("List", "Language");
        //}
        //[HttpGet]
        //public ActionResult Delete(int Id=0,string AY_ENV_ID="")
        //{
        //    return View(objDb.Languages.Find(Id,AY_ENV_ID));
        //}

        //[HttpPost, ActionName("Delete")]
        //public ActionResult DeleteLanguage(int Id,string AY_ENV_ID)
        //{


        //        objDb.Languages.Remove(objDb.Languages.Find(Id, AY_ENV_ID));
        //        objDb.SaveChanges();

        //        return RedirectToAction("List", "Language");
            
        //}

        //[HttpGet]
        //public ActionResult Details(int Id=0,String AY_ENV_ID="")
        //{
        //    return View(objDb.Languages.Find(Id,AY_ENV_ID));
        //}

    }
}