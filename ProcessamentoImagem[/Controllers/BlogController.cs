using Microsoft.AspNetCore.Mvc;
using ProcessamentoImagem.Application.AppServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessamentoImagem_.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
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
