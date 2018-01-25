using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjetoEstudo.Domain.Entities.Pessoa;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProjetoEstudo.Infra.Context
{
    public class ProjetoContext : DbContext
    {
        private IConfigurationRoot Configuration { get; set; }

        public ProjetoContext(DbContextOptions<ProjetoContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Pessoa> Pessoa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(ObterConnectionString());
        }

        private string ObterConnectionString()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            return Configuration.GetConnectionString("DefaultConnection");
        }
    }
}