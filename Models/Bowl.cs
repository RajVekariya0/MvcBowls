using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public string Uses { get; set; }
        [Column(TypeName = "decimal(18, 2)")]

        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18, 2)")]

        public decimal Rating { get; set; }

    }
}
