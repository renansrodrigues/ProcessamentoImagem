using ProcessamentoImagem.Domain.Services.Interface;
using ProcessamentoImagem.Domain.Services.Model;
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

        public async Task<string> Inserir(Imagem request)
        {
            

          await  _arquivoService.UploadArquivoImagemAsync(Convert.FromBase64String(request.Arquivo), request.Nome, request.Extensao);

            return "Concluido";
        }

    }
}
