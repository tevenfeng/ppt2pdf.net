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

        /// <summary>
        /// 转换函数
        /// </summary>
        /// <param name="sourcePath">源文件路径</param>
        /// <param name="savePath">保存的路径</param>
        /// <returns></returns>
        public bool Convert(string sourcePath,string savePath)
        {
            bool result = false;

            PowerPoint.PpSaveAsFileType targetFileType = PowerPoint.PpSaveAsFileType.ppSaveAsPDF;
            object missing = Type.Missing;

            try
            {
                pptApplication = new PowerPoint.ApplicationClass();
                presentation = pptApplication.Presentations.Open(sourcePath,
                                                                MsoTriState.msoTrue,
                                                                MsoTriState.msoFalse,
                                                                MsoTriState.msoFalse);
                presentation.SaveAs(savePath, targetFileType, MsoTriState.msoTrue);
                result = true;
            }
            catch
            {
                result = false;
            }
            finally
            {
                if (presentation != null)
                {
                    presentation.Close();
                    presentation = null;
                }

                if (pptApplication != null)
                {
                    pptApplication.Quit();
                    pptApplication = null;
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }

            return result;
        }
    }
}
