using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using BUSAPI.Models;
using Microsoft.EntityFrameworkCore;
using BUSAPI.Models;
using BUSAPI.Models.Enuns;
using Swashbuckle.AspNetCore.SwaggerUI;


namespace BUSAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }

        public DbSet<Onibus> TB_ONIBUS { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Onibus>().ToTable("TB_ONIBUS");

            modelBuilder.Entity<Onibus>().HasData // perguntar sobre hasdata
            (
            
            new Onibus() { Id = 1, Linha = "1234A",  NomeLinha = "Parque Luiz Fernando", PontoPartida = "Parque Luiz Cardoso", PontoFinal = "Av. Vitor Luz", TempoEspera = 05, Situacao = Situacoes.Ativo},
            new Onibus() { Id = 2, Linha = "1345A",  NomeLinha = "Av. Professora Quitereia", PontoPartida = "Av. Professora Quiteria", PontoFinal = "R. Sarjento Bruno", TempoEspera = 15, Situacao = Situacoes.Ativo},
            new Onibus() { Id = 3, Linha = "1456A",  NomeLinha = "Vila Guilherme", PontoPartida = "Vila Guilherme", PontoFinal = "Rua Soldado   Brad kynndy", TempoEspera = 25, Situacao = Situacoes.Ativo},
            new Onibus() { Id = 4, Linha = "1567A",  NomeLinha = "AV. Marion", PontoPartida = "Av. Marion", PontoFinal = "Rua Professora Fatima", TempoEspera = 35, Situacao = Situacoes.Ativo},
            new Onibus() { Id = 5, Linha = "1678A",  NomeLinha = "Av. Eduardo Kaue", PontoPartida = "Av. Eduardo Kaue", PontoFinal = " Rua Senior Bruno Leitao", TempoEspera = 45, Situacao = Situacoes.Manutenção}
            
            );
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveColumnType("varchar").HaveMaxLength(200);
        }

    }

}