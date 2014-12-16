using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Core;
using PowerPoint=Microsoft.Office.Interop.PowerPoint;

namespace ppt2pdf.net
{
    /// <summary>
    /// 把ppt转换成pdf格式
    /// </summary>
    class ppt2pdfConverter
    {
        private PowerPoint.Presentation presentation;
        PowerPoint.ApplicationClass pptApplication;

        public ppt2pdfConverter()
        {
            pptApplication = null;
            presentation = null;
        }

        public void Convert(string sourcePath,string savePath)
        {

        }
    }
}
