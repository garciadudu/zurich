using Seguros.Zurich.Domain.Core.Interface.Repository;
using Seguros.Zurich.Domain.Core.Service;
using Seguros.Zurich.Domain.Entities.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.Zurich.Servicos.Service
{
    public class ServiceSeguro : IServiceSeguro
    {
        public readonly IRepositorySeguro _repository;

        public ServiceSeguro(IRepositorySeguro repository)
        {
            _repository = repository;
        }

        public void Add(Seguro obj)
        {
            _repository.Add(obj);
        }

        public async Task AddAsync(Seguro obj)
        {
            await _repository.AddAsync(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public IEnumerable<Seguro> GetAll()
        {
            return _repository.GetAll();
        }

        public async Task<IEnumerable<Seguro>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public Seguro GetById(int id)
        {
            return _repository.GetById(id);
        }

        public async Task<Seguro> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Seguro> GetByCPFAsync(string cpf)
        {
            return await _repository.GetByCPFAsync(cpf);
        }


        public void Remove(Seguro obj)
        {
            _repository.Remove(obj);
        }

        public void Update(Seguro obj)
        {
            _repository.Update(obj);
        }
    }
}
