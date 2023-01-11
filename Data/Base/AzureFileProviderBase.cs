using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SfFileService.FileManager.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;
using Syncfusion.EJ2.FileManager.Base;

namespace SfFileService.FileManager.Base
{
    public interface AzureFileProviderBase : FileProviderBase
    {
        void RegisterAzure(string accountName, string accountKey, string blobName);
    }

}
