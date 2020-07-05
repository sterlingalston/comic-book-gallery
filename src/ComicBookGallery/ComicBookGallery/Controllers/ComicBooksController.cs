using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            return View();
        }
    }

    
}
