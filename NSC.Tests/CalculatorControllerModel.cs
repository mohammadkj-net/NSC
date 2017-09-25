using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSC.Models;
using NSC.Controllers;
using System.Web.Mvc;

namespace NSC.Tests
{
    [TestClass]
    public class CalculatorControllerModel
    {
        [TestMethod]
        public void CalculatorViewTest()
        {
            CalculatorController _controller = new CalculatorController();
            ViewResult _view = _controller.CalculatorView() as ViewResult;

            Assert.AreEqual("CalculatorView", _view.ViewName);
        }

        [TestMethod]
        public void GenerateNumbersTest()
        {
            CalculatorController _controller = new CalculatorController();
            CalculatorModel _model = new CalculatorModel();
            _model.UserInput = 3;
            PartialViewResult _view = _controller.GenerateNumbers(_model) as PartialViewResult;

            Assert.AreEqual("_generateNumbersView", _view.ViewName);
        }

        [TestMethod]
        public void GenerateNumbersTestWithNullModel()
        {
            CalculatorController _controller = new CalculatorController();
            _controller.ModelState.AddModelError("error", "error message");
            CalculatorModel _model = new CalculatorModel();            
            PartialViewResult _view = _controller.GenerateNumbers(_model) as PartialViewResult;

            Assert.AreEqual("_onErrorView", _view.ViewName);
        }
    }
}
