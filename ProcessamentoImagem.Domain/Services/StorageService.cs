using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.File;
using ProcessamentoImagem.Domain.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessamentoImagem.Domain.Services
{
    public class StorageService : IStorageService
    {

        public  CloudFileClient ObtemConexaoBlob()
        {            

            string accountName = "storageprocessadorarq";
            string keyValue = "";

            CloudStorageAccount storageAccount = new CloudStorageAccount(new StorageCredentials(accountName, keyValue), true);
            return storageAccount.CreateCloudFileClient();
        }


    }
}
