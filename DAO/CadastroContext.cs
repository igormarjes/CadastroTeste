using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroTeste.Models;

namespace CadastroTeste.DAO
{
    public class CadastroContext : DbContext
    {
        public CadastroContext(DbContextOptions<CadastroContext> options) : base(options)
        {

        }

        public DbSet<Cadastro> Cadastros { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
               builder.Entity<Cadastro>().HasKey(m => m.Id);
               base.OnModelCreating(builder);
        }
    }
}