using Seguros.Zurich.Domain.Entities.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.Zurich.Domain.Core.Interface.Repository
{
    public interface IRepositorySeguro
    {
        void Add(Seguro obj);
        Task AddAsync(Seguro obj);
        Seguro GetById(int id);
        IEnumerable<Seguro> GetAll();
        void Update(Seguro obj);

        void Remove(Seguro obj);

        void Dispose();
        Task<IEnumerable<Seguro>> GetAllAsync();
        Task<Seguro> GetByIdAsync(int id);
        Task<Seguro> GetByCPFAsync(string cpf);        
    }        
}
