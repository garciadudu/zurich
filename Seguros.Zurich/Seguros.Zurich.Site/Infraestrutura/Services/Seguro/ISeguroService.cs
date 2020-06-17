using Seguros.Zurich.Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seguros.Zurich.Site.Infraestrutura.Services.Seguro
{
    public interface ISeguroService
    {
        Task<List<SeguroViewModel>> ListarAsync();
        Task<List<SeguroViewModel>> ListarMediaAsync();

        Task<SeguroViewModel> ObterAsync(int id);
        Task<SeguroViewModel> ObterAsync(string cpf);

        Task CadastrarAsync(SeguroViewModel condominio);

        Task AtualizarAsync(SeguroViewModel condominio);
        Task ExcluirAsync(int id);

    }
}
