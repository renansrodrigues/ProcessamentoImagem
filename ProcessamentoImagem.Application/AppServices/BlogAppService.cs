using ProcessamentoImagem.Application.AppServices.Interfaces;
using ProcessamentoImagem.Domain.Services.Interface;
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

        public async Task Inserir(dynamic request)
        {
            _blogService.Inserir(request);
        }

    }
}
