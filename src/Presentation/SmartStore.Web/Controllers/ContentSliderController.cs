﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartStore.Web.Controllers
{
    public class ContentSliderController : Controller
    {
        public ContentSliderController()
        {

        }

        [ChildActionOnly]
        public ActionResult HomepageContentSlider()
        {
            return PartialView();
        }
    }
}