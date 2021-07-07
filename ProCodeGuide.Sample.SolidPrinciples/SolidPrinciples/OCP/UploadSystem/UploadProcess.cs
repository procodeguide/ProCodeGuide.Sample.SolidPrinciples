using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.SolidPrinciples.SolidPrinciples.OCP.UploadSystem
{
    public class UploadProcess
    {
        public bool UploadFile()
        {
            IUploadOrderFile orderFile = null;

            //if XML File
            {
                orderFile = new UploadXMLOrderFile();
            }

            //if JSON File
            {
                orderFile = new UploadJSONOrderFile();
            }

            Object orderObj = orderFile.ProcessOrderFile();

            //Validate Records

            //Save Records

            return true;
        }
    }
}
