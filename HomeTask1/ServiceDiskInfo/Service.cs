using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ServiceDiskInfo
{
    class Service:IDiskInfo
    {
        public string[] GetDiskInfo(string path)
        {
            return Directory.GetFileSystemEntries(@path);
        }
    }
}
