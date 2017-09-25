using NSC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NSC.Controllers
{
    public class CalculatorController : Controller
    {
        public ActionResult CalculatorView()
        {
            return View("CalculatorView");
        }
        
        public PartialViewResult GenerateNumbers(CalculatorModel model)
        {
            if (!ModelState.IsValid)
            {
                foreach (ModelState modelState in ViewData.ModelState.Values)
                {
                    foreach (ModelError error in modelState.Errors)
                    {
                        model.ErrorMessage = error.ErrorMessage;
                    }
                }
                return PartialView("_onErrorView", model);
            }
            else
            {
                model.AllNumbers = Models.GenerateNumbers.GetAllNumbers(model.UserInput);
                model.OddNumbers = Models.GenerateNumbers.GetOddNumbers(model.UserInput);
                model.EvenNumbers = Models.GenerateNumbers.GetEvenNumbers(model.UserInput);
                model.CustomNumbers = Models.GenerateNumbers.GetCustomNumbers(model.UserInput);
                model.FibonacciNumbers = Models.GenerateNumbers.GetFibonacciNumbers(model.UserInput);

                return PartialView("_generateNumbersView", model);
            }
        }        
    }
}