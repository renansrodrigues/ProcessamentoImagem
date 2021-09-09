
using Microsoft.WindowsAzure.Storage.File;
using ProcessamentoImagem.Domain.Services.Interface;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ProcessamentoImagem.Domain.Services
{
    public class ArquivoService : IArquivoService
    {

        private readonly IStorageService _IStorageService;

        public ArquivoService(IStorageService storageService)
        {
            _IStorageService = storageService;
        }


        public async Task UploadArquivoImagemAsync(byte[] text, string fileName, string extensaoArquivo)
        {
            string azureFileShareName;

            try
            {
                azureFileShareName = "imagens";

                CloudFileShare fileShare = _IStorageService.ObtemConexaoBlob().GetShareReference(azureFileShareName);

                if (await fileShare.ExistsAsync())
                {
                    CloudFileDirectory rootDir = fileShare.GetRootDirectoryReference();
                    CloudFileDirectory diretorioArquivos = rootDir.GetDirectoryReference("imagemUpload");
                    if (await diretorioArquivos.ExistsAsync())
                    {
                                                                           
                                string nomearquivo = $"{fileName}.{extensaoArquivo}";
                                CloudFile myfile = diretorioArquivos.GetFileReference(nomearquivo);
                                Stream fileStream = new MemoryStream(text);
                                await myfile.UploadFromStreamAsync(fileStream);
                                                    
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}
