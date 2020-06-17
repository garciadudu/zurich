using AutoMapper;
using Seguros.Zurich.AplicacaoDTO.DTO;
using Seguros.Zurich.Domain.Entities.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seguros.Zurich.Infraestrutura.CrossCutting.Adapter.Map
{
    public static class Mapeador
    {
        static MapperConfiguration configuration;

        static Mapeador()
        {
            configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Seguro, SeguroDTO>();
                cfg.CreateMap<SeguroDTO, Seguro>();

            });
        }

        public static TDestino Mapear<TOrigem, TDestino>(TOrigem origem)
                where TOrigem : class
                where TDestino : class
        {
            var mapper = configuration.CreateMapper();
            return mapper.Map<TOrigem, TDestino>(origem);
        }

    }

}
