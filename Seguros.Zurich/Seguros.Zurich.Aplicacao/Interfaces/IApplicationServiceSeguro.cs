using Seguros.Zurich.AplicacaoDTO.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.Zurich.Aplicacao.Interfaces
{
    public interface IApplicationServiceSeguro
    {
        void Add(SeguroDTO obj);
        Task AddAsync(SeguroDTO obj);
        SeguroDTO GetById(int id);
        IEnumerable<SeguroDTO> GetAll();
        void Update(SeguroDTO obj);
        void Remove(SeguroDTO obj);
        Task<IEnumerable<SeguroDTO>> GetAllAsync();
        Task<SeguroDTO> GetByIdAsync(int id);
        Task<SeguroDTO> GetByCPFAsync(string cpf);
        void Dispose();
    }
}
