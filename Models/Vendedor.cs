using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabalhoFinal.Models

{public class Vendedor
    {
        [Display(Name = "Id do vendedor")]
        public int Id { get; set; }
        [Display(Name = "Nome do vendedor")]
        public string? Nome { get; set; }
    }
}