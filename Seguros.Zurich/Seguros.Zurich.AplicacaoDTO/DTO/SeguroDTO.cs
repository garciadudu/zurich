using System;
using System.Collections.Generic;
using System.Text;

namespace Seguros.Zurich.AplicacaoDTO.DTO
{
    public class SeguroDTO
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
