using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProcessamentoImagem.Domain.Services.Interface
{
    public interface IBlogService
    {
        Task Inserir(dynamic request);

    }
}
