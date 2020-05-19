using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.MVC.Learning.Models
{
    public class TestModel
    {
        [Required(ErrorMessage ="please add your name")]
        public string Name { get; set; }
        public string TheLoveYouLoveMost { get; set; }
    }
}
