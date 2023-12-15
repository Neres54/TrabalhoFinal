using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabalhoFinal.Models
{
    public class PagamentoComCheque : TipoDePagamneto
    {
        [Display(Name = "Banco")]
        public int Banco { get; set; }
        [Display(Name = "Nome do banco")]
        public string? NomeDoBanco { get; set; }
    }
}