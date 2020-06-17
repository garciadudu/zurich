using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seguros.Zurich.Site.Models
{
    public class SeguroViewModel
    {
        public int Id { get; set; }
        public decimal valorVeiculo { get; set; }
        public decimal taxaRisco { get; set; }
        public decimal premioRisco { get; set; }
        public decimal premioPuro { get; set; }
        public decimal premioComercial { get; set; }
        public decimal valorSeguro { get; set; }

        public string marcaVeiculo { get; set; }
        public string modeloVeiculo { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
    }
}
