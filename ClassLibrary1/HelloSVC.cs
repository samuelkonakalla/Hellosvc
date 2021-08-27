using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ClassLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloSVC" in both code and config file together.

    public class HelloSVCpubPrivate :  IHellopublicSVC, IHelloPrivateSVC
    {
        

        public string privatesvc(string name)
        {
            return "privatesvc:" + name;
        }

        public string publicsvc(string name)
        {
            return "pulicsvc: " + name;
        }
    }
    public class HelloSVC : IHelloSVC
    {
        public string DoWork()
        {
            return "I'm from HelloSVC";
        }

    }
}
