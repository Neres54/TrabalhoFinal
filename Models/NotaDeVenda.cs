using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabalhoFinal.Models
{
    public class NotaDeVenda
    {
    [Key]
    [Display(Name = "Id nota de venda")]
    public int Id { get; set; }
    [Display(Name = "Id pagamento")]
    public int IdPagamento { get; set; }
    [Display(Name = "Id transportadora")]
    public int IdTransportadora { get; set; }
    [Display(Name = "Id Vendedor")]
    public int IdVendedor { get; set; }
    [Display(Name = "Id Cliente")]
    public int IdCliente { get; set; }
    [Display(Name = "Data")]
    public DateTime Data { get; set; }
    [Display(Name = "Tipo")]
    public bool Tipo { get; set; }
    public virtual ICollection<Item>? Items {get; set;}
    public bool Cancelado = false;
    public bool Devolvido = false;
    public bool Cancelar(){

        Cancelado = true;
        return true;
        }
    public bool Devolver(){
        Devolvido = true;
        return true;
        }
        
    }
}