using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BUSAPI.Models.Enuns;

namespace BUSAPI.Models
{
    public class Onibus
    {
        public int Id { get; set; }

        public string Linha { get; set; }

        public string NomeLinha { get; set; }

        public string PontoPartida { get; set; }

        public string PontoFinal { get; set; }

        public int TempoEspera { get; set; }

        public Situacoes Situacao { get; set; }

    }
}