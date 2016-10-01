using OfficeArrangament.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeArrangement.Sandbox
{
    public partial class FormMain : Form
    {
        private Map _map;

        public FormMain()
        {
            InitializeComponent();

            //string content =
            //    "FFTTCC\n" +
            //    "PPFFXX\n" +
            //    "TCPFXT";
            _map = new Map();
            //map.LoadData(content);
            //Bitmap image = map.Draw();
            //pictureBoxMain.Image = image;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
