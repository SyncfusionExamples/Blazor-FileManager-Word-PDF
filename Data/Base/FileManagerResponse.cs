using System;
using System.Collections.Generic;
using System.Linq;
using SfFileService.FileManager.Base;

namespace Syncfusion.EJ2.FileManager.Base
{

    public class FileManagerResponse
    {

        public FileManagerDirectoryContent? CWD { get; set; }
        public IEnumerable<FileManagerDirectoryContent>? Files { get; set; }

        public ErrorDetails? Error { get; set; }

        public FileDetails? Details { get; set; }

    }

}