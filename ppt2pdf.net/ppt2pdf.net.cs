using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppt2pdf.net
{
    public partial class mainForm : Form
    {
        private Point offset;
        private OpenFileDialog myFileDialog = new OpenFileDialog();
        private string[] fileNames;
        private string path;
        private ppt2pdfConverter myPpt2PdfConverter;

        public mainForm()
        {
            InitializeComponent();
            this.Focus();
            mainForm_addEventHandlers();
        }

        private void mainForm_addEventHandlers()
        {
            this.MouseDown += new MouseEventHandler(this.mainForm_MouseDown);
            this.MouseUp += new MouseEventHandler(this.mainForm_MouseUp);
            this.button_Convert.KeyDown += new KeyEventHandler(this.mainForm_KeyDown);
            this.button_Explore.KeyDown += new KeyEventHandler(this.mainForm_KeyDown);
        }

        private void mainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) { return; }
            Point currentPosition = this.PointToScreen(e.Location);
            offset = new Point(currentPosition.X-this.Left,currentPosition.Y-this.Top);
        }

        private void mainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) { return; }
            Point currentPosition = MousePosition;
            this.Location = new Point(currentPosition.X - offset.X, currentPosition.Y - offset.Y);
        }

        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void button_Explore_Click(object sender, EventArgs e)
        {
            myFileDialog.Multiselect = true;
            myFileDialog.Filter = "(PPT文件)|*.ppt;*.pptx";
            if (myFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileNames = myFileDialog.FileNames;
                path = System.IO.Path.GetDirectoryName(fileNames[0]);
            }
        }

        private void button_Convert_Click(object sender, EventArgs e)
        {
            bool result = true;
            myPpt2PdfConverter = new ppt2pdfConverter();

            foreach (string file in fileNames)
            {
                string fileName = file.Substring(file.LastIndexOf("\\") + 1, file.LastIndexOf(".")-1-file.LastIndexOf("\\"));
                if (myPpt2PdfConverter.Convert(file, path + "\\" + fileName + ".pdf") != true)
                {
                    result = false;
                }
            }

            if (result == true)
            {
                MessageBox.Show("转换成功！");
            }
            else
            {
                MessageBox.Show("转换失败，请重试！");
            }
        }
    }
}
