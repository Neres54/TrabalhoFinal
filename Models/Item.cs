using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabalhoFinal.Models
{
    public class Item
    {
        [Display(Name = "Id Item")]
        public int Id { get; set; }
        [Display(Name = "Id Produto")]
        public int IdProduto { get; set; }
        [Display(Name = "Percentual")]
        public int Percentual { get; set; }
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }
        public virtual ICollection<Produto>? Produtos {get; set;}
         [Display(Name = "Preco")]
        public double Preco { get; set; }
    }
}