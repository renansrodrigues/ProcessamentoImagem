using ProcessamentoImagem.Domain.Services.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProcessamentoImagem.Domain.Services.Interface
{
    public interface IBlogService
    {
        Task<string> Inserir(Imagem request);

    }
}
