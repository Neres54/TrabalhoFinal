using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabalhoFinal.Models
{
    public class TipoDePagamneto
    {
        [Display(Name = "Id forma de pagamento")]
        public int Id { get; set; }
        [Display(Name = "Id tipo de pagamento")]
        public int IdTipoDePagamento { get; set; }
        [Display(Name = "Nome do cobrado")]
        public string? NomeDoCobrado { get; set; }
        [Display(Name = "Informacoes adicionais")]
        public string? InformacoesAdicionais { get; set; }
    }
}