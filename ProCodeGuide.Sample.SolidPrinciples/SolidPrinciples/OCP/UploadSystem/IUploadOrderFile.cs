using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.SolidPrinciples.SolidPrinciples.OCP.UploadSystem
{
    public interface IUploadOrderFile
    {
        object ProcessOrderFile();
    }
}
