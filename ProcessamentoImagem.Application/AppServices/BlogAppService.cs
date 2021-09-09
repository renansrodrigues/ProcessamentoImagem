using ProcessamentoImagem.Application.AppServices.Interfaces;
using ProcessamentoImagem.Domain.Services.Interface;
using ProcessamentoImagem.Domain.Services.Model;
using System.Threading.Tasks;

namespace ProcessamentoImagem.Application.AppServices
{
    public class BlogAppService : IBlogAppService
    {
        private readonly IBlogService _blogService;

        public BlogAppService(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task<string> Inserir(Imagem request)
        {
          return  await _blogService.Inserir(request);
        }

    }
}
