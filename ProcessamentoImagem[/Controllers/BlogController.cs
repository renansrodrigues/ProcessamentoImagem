using Microsoft.AspNetCore.Mvc;
using ProcessamentoImagem.Application.AppServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessamentoImagem_.Controllers
{
    public class BlogController : Controller
    {

        private IBlogAppService _blogAppService;

        public BlogController(IBlogAppService blogAppService)
        {
            _blogAppService = blogAppService;
        }


        [HttpPost("inserir")]
        public async Task<IActionResult> Inserir(dynamic request) => Ok(await _blogAppService.Inserir(request));
    }
}
