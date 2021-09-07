using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProcessamentoImagem.Domain.Services.Interface
{
    public  interface IArquivoService
    {
        Task UploadArquivoImagemAsync(byte[] text, string fileName, string extensaoArquivo);


    }
}
