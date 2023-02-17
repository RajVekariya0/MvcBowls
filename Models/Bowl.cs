using System;
using System.ComponentModel.DataAnnotations;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBowls.Models
{
    public class Bowl
    {
        public int Id { get; set; }
        public string VarietyOfBowls { get; set; }
        public string Color { get; set; }

        public string Material { get; set; }
        public decimal Uses { get; set; }
        public decimal Price { get; set; }
        public decimal Rating { get; set; }

    }
}
