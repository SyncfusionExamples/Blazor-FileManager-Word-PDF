using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace Syncfusion.EJ2.FileManager.Base
{
    public class FileManagerParams
    {
       public string Name { get; set; } = string.Empty;

        public string[]? Names { get; set; }

        public string Path { get; set; } = string.Empty;

        public string TargetPath { get; set; } = string.Empty;

        public string NewName { get; set; } = string.Empty;

        public object? Date { get; set; }
#if EJ2_DNX
        public IEnumerable<System.Web.HttpPostedFileBase> FileUpload { get; set; }
#else

        public IEnumerable<IFormFile>? FileUpload { get; set; }

#endif

        public string[]? RenameFiles { get; set; }
    }
}