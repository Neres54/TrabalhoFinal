using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabalhoFinal.Models
{
    public class Cliente
    {
    [Display(Name = "Id Cliente")]
    public int Id { get; set; }
    [Display(Name = "Nome Cliente")]
    public string? Nome { get; set; }
    }
}