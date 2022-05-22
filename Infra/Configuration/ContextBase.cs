using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Configuration
{
    public class ContextBase : DbContext

    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConnectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }

        private string GetStringConnectionConfig() 
        {
            string strCon = "Data Source=DESKTOP-CE6K1CE\\LOJA_VIRTUAL; Initial Catalog = Loja_Virtual; Integrated Security = False; User ID = sa; Password = 12345678; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = False; ";
            return strCon;
        }

    }
}
