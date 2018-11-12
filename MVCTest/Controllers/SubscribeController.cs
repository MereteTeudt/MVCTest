using MVCTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Controllers
{
    public class SubscribeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Subscribe(SubscribeModel subscribeModel)
        {
            ResponseModel responseModel = new ResponseModel();
            if (ModelState.IsValid)
            {
                responseModel.Success = true;
                responseModel.ResponseMessage = "You've been subscribed.";
            }

            return View("Subscribe", responseModel);
        }
    }
}