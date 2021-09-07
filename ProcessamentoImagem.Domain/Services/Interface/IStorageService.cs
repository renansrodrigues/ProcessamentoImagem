using Microsoft.WindowsAzure.Storage.File;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessamentoImagem.Domain.Services.Interface
{
    public interface IStorageService
    {
        CloudFileClient ObtemConexaoBlob();
    }
}
