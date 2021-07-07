using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.SolidPrinciples.SolidPrinciples.OCP.UploadSystem
{
    public class UploadXMLOrderFile : IUploadOrderFile
    {
        public object ProcessOrderFile()
        {
            object orderObj = null;
            
            //Parse XML File to DTO Object

            return orderObj;
        }
    }
}
