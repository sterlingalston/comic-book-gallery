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
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday) 
            {
                return new RedirectResult("/");
            }

            return new ContentResult() 
            {
                Content = "Hello from the comic books controller."
            };
            //return "Hello from the comic books controller.";
        }

    }
}
