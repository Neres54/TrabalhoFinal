using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TrabalhoFinal.Models
{
    public class MyDbContext : DbContext
    {
         public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
       {
       }

public DbSet<Marca>? Marca {get; set;}
public DbSet<Produto>? Produto {get; set;}
public DbSet<Item>? Item {get; set;}
public DbSet<NotaDeVenda>? NotaDeVenda {get; set;}
public DbSet<Cliente>? Cliente {get; set;}
public DbSet<Vendedor>? Vendedor {get; set;}
public DbSet<Transportadora>? Transportadora {get; set;}
public DbSet<Pagamento>? Pagamento {get; set;}
public DbSet<TipoDePagamneto>? TipoDePagamneto {get; set;}
public DbSet<PagamentoComCheque>? PagamentoComCheque {get; set;}
public DbSet<PagamentoComCartao>? PagamentoComCartao {get; set;}        
    }
}