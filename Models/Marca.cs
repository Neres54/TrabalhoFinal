using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabalhoFinal.Models
{
    public class Marca
    {
        [Display(Name = "Id marca")]
        public int Id { get; set; }
        [Display(Name = "Nome marca")]
        public string? Nome { get; set; }
        [Display(Name = "Descricao")]
        public string? Descricao { get; set; }
    }
}