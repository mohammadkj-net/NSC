using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NSC.Models
{    
    public class CalculatorModel
    {
        [Required(ErrorMessage ="Please enter integer number")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Please enter valid integer number")]
        public int UserInput{ get; set; }
        public string ErrorMessage { get; set; }
        public List<int> AllNumbers { get; set; }
        public List<int> OddNumbers { get; set; }
        public List<int> EvenNumbers { get; set; }
        public List<string> CustomNumbers { get; set; }
        public List<int> FibonacciNumbers { get; set; }
    }
}