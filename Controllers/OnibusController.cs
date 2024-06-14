using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BUSAPI.Models;
using BUSAPI.Models.Enuns;
using Microsoft.AspNetCore.Mvc;

namespace BUSAPI.Controllers
{
     [ApiController]
     [Route("[Controller]")]
    public class OnibusController : ControllerBase
    {
        private static List<Onibus> LinhaAzul = new List<Onibus>()
        {
            new Onibus() { Id = 1, Linha = "1234A",  NomeLinha = "Parque Luiz Fernando", PontoPartida = "Parque Luiz Cardoso", PontoFinal = "Av. Vitor Luz", TempoEspera = 05, Situacao = Situacoes.Ativo},
            new Onibus() { Id = 2, Linha = "1345A",  NomeLinha = "Av. Professora Quitereia", PontoPartida = "Av. Professora Quiteria", PontoFinal = "R. Sarjento Bruno", TempoEspera = 15, Situacao = Situacoes.Ativo,},
            new Onibus() { Id = 3, Linha = "1456A",  NomeLinha = "Vila Guilherme", PontoPartida = "Vila Guilherme", PontoFinal = "Rua Soldado   Brad kynndy", TempoEspera = 25, Situacao = Situacoes.Ativo},
            new Onibus() { Id = 4, Linha = "1567A",  NomeLinha = "AV. Marion", PontoPartida = "Av. Marion", PontoFinal = "Rua Professora Fatima", TempoEspera = 35, Situacao = Situacoes.Ativo},
            new Onibus() { Id = 5, Linha = "1678A",  NomeLinha = "Av. Eduardo Kaue", PontoPartida = "Av. Eduardo Kaue", PontoFinal = " Rua Senior Bruno Leitao", TempoEspera = 45, Situacao = Situacoes.Manutenção,},

        };


    }
}