using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        FilterScreen fs;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fs =new FilterScreen();
            fs.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Controls.Clear();          //anasayfa butonu click lenince refresh ediyor.
            this.InitializeComponent();
        }

        private void popupGalleryEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
