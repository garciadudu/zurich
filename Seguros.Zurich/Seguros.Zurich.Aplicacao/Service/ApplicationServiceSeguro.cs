using Seguros.Zurich.Aplicacao.Interfaces;
using Seguros.Zurich.AplicacaoDTO.DTO;
using Seguros.Zurich.Domain.Core.Service;
using Seguros.Zurich.Domain.Entities.Dominio;
using Seguros.Zurich.Infraestrutura.CrossCutting.Adapter.Map;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.Zurich.Aplicacao.Service
{
    public class ApplicationServiceSeguro : IApplicationServiceSeguro
    {
        private readonly IServiceSeguro _serviceSeguro;
        public ApplicationServiceSeguro(IServiceSeguro serviceSeguro)
        {
            _serviceSeguro = serviceSeguro;
        }

        public void Add(SeguroDTO obj)
        {
            try
            {
                var objNew = Mapeador.Mapear<SeguroDTO, Seguro>(obj);

                decimal margemSeguranca = 0.03m;
                decimal lucro = 0.05m;

                objNew.taxaRisco = (objNew.valorVeiculo * 5) / (2 * obj.valorVeiculo);
                objNew.premioRisco = objNew.taxaRisco * objNew.valorVeiculo / 100;
                objNew.premioPuro = objNew.premioRisco * (1 + margemSeguranca);
                objNew.premioComercial = (1+lucro) * objNew.premioPuro;

                objNew.valorSeguro = objNew.premioComercial;

                _serviceSeguro.Add(objNew);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Dispose()
        {
            _serviceSeguro.Dispose();
        }
        public IEnumerable<SeguroDTO> GetAll()
        {
            var objSeguros = _serviceSeguro.GetAll();
            return Mapeador.Mapear<IEnumerable<Seguro>, IEnumerable<SeguroDTO>>(objSeguros);
        }
        public SeguroDTO GetById(int id)
        {
            var obj = _serviceSeguro.GetById(id);
            return Mapeador.Mapear<Seguro, SeguroDTO>(obj);
        }
        public async Task<SeguroDTO> GetByIdAsync(int id)
        {
            var obj = await _serviceSeguro.GetByIdAsync(id);
            return Mapeador.Mapear<Seguro, SeguroDTO>(obj);
        }

        public async Task<SeguroDTO> GetByCPFAsync(string cpf)
        {
            var obj = await _serviceSeguro.GetByCPFAsync(cpf);
            return Mapeador.Mapear<Seguro, SeguroDTO>(obj);
        }

        public void Remove(SeguroDTO obj)
        {
            var objNew = Mapeador.Mapear<SeguroDTO, Seguro>(obj);
            _serviceSeguro.Remove(objNew);
        }
        public void Update(SeguroDTO obj)
        {
            try
            {
                var objNew = Mapeador.Mapear<SeguroDTO, Seguro>(obj);

                _serviceSeguro.Update(objNew);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<SeguroDTO>> GetAllAsync()
        {
            var objSeguros = await _serviceSeguro.GetAllAsync();
            return Mapeador.Mapear<IEnumerable<Seguro>, IEnumerable<SeguroDTO>>(objSeguros);
        }

        public async Task AddAsync(SeguroDTO obj)
        {
            try
            {
                var objNew = Mapeador.Mapear<SeguroDTO, Seguro>(obj);

                await _serviceSeguro.AddAsync(objNew);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
