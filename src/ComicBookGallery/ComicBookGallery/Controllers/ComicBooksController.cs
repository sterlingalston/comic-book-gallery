using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicBookGallery.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController: Controller
    {
        //public ContentResult Detail() 
        #region
        //public ActionResult Detail()
        //{
        //    if (DateTime.Today.DayOfWeek == DayOfWeek.Sunday) 
        //    {
        //        //return new RedirectResult("/");
        //        return Redirect("/");
        //    }

        //    return Content("Hello from the comic books controller.");

        //  /*  return new ContentResult() 
        //    {
        //        Content = "Hello from the comic books controller."
        //    };*/
        //    //return "Hello from the comic books controller.";
        //}

        #endregion

        public ActionResult Detail()
        {


            #region old ViewBag code
            /*
            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };*/
            #endregion


            return View(comicBook);
        }
    }

    
}
