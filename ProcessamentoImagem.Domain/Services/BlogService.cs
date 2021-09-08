using ProcessamentoImagem.Domain.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProcessamentoImagem.Domain.Services
{
    public class BlogService : IBlogService
    {

        public IArquivoService _arquivoService;
        public BlogService(IArquivoService arquivoService)
        {
            _arquivoService = arquivoService;
        }

        public async Task Inserir(dynamic request)
        {
            

            _arquivoService.UploadArquivoImagemAsync(Convert.FromBase64String(request.Objimagem.arquivo), request.Objimagem.nome, request.Objimagem.extensao);

        }

    }
}
