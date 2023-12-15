using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabalhoFinal.Models
{
    public class Pagamento
    {
    [Display(Name = "Id pagamento")]
    public int Id { get; set; }
    [Display(Name = "Data limite")]
    public DateTime DataLimite { get; set; }
    [Display(Name = "Valor")]
    public double Valor { get; set; }
    public bool Pago { get; set; }
    }
}