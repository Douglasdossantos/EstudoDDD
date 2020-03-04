using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Configuracao
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) :base(options)
        {
                
        }
        public DbSet<Produto> Produto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConnectionConfigure());
            }
            base.OnConfiguring(optionsBuilder);
        }
        private string GetStringConnectionConfigure()
        {
            string strConn = "um teste qualquer da maquina";
            return strConn;
        }
    }
}
