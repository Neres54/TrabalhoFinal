using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabalhoFinal.Models
{
    public class PagamentoComCartao : TipoDePagamneto
    {
    [Display(Name = "Numero do cartão")]
    public string? NumeroDoCartao { get; set; }
    [Display(Name = "Bandeira do cartão")]
    public string? Bandeira { get; set; }
    }
}