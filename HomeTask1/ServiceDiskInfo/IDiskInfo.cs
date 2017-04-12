using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ServiceDiskInfo
{
    [ServiceContract]
    interface IDiskInfo
    {
        [OperationContract]
        string[] GetDiskInfo(string path);
    }
}
