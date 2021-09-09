using ProcessamentoImagem.Domain.Services.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProcessamentoImagem.Application.AppServices.Interfaces
{
    public interface IBlogAppService
    {
        Task<string> Inserir(Imagem request);

    }
}
