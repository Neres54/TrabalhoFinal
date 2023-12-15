using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabalhoFinal.Models
{
    public class Produto
    {
        [Display(Name = "Id do produto")]
        public int Id { get; set; }
        [Display(Name = "Id da marca")]
        public int IdMarca { get; set; }
        [Display(Name = "Nome do produto")]
        public string? Nome { get; set; }
        [Display(Name = "Descricao")]
        public string? Descricao { get; set; } 
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }
        [Display(Name = "Preco")]
        public double Preco { get; set; }
    }
}