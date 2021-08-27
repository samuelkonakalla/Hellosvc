using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ClassLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHelloSVC" in both code and config file together.
    [ServiceContract]
    public interface IHelloSVC
    {
        [OperationContract]
        string DoWork();
    }
    [ServiceContract]
    public interface IHellopublicSVC
    {
        [OperationContract]
        string publicsvc(string name);
    }
    [ServiceContract]
    public interface IHelloPrivateSVC
    {
        [OperationContract]
        string privatesvc(string name);
    }
}
