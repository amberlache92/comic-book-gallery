﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController: Controller
    {
       public ActionResult Detail()

        {
            if(DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
            {
                return new RedirectResult("/");
            }
            return new ContentResult()
            {
                Content= "hello from the comic book controller "
            };
           // return "hello from the comic book controller";
        }
    }
}