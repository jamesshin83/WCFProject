using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GettingStartedWebClient.CalculatorService;

namespace GettingStartedWebClient.Controllers
{
    public class CalculateController : Controller
    {
        // GET: Calculate
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add(double num1, double num2)
        {
            CalculatorClient client = new CalculatorClient();

            var result = client.add(num1, num2);

            ViewBag.AddResult = result;

            return View();
        }
    }
}