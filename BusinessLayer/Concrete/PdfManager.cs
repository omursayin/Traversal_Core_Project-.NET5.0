using BusinessLayer.Abstract;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PdfManager : IPdfService
    {
        public byte[] ExcelList<T>(List<T> t) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
