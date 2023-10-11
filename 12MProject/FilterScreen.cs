using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors.ColorPick.Picker;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test
{
    public partial class FilterScreen : Form
    {
        public FilterScreen()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (TxtBaslangicTarihi.Text.Length == 0)
            {
                MessageBox.Show("Lütfen Veri Giriniz!");

            }
            else
            {

                
            }

            string connectionString = "Data Source=DESKTOP-URKG832\\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_StokEkstresi", con);
            cmd.CommandType = CommandType.StoredProcedure;

            string malKodu = TxtMalKodu.Text;
            int baslangicTarihi = Convert.ToInt32((Convert.ToDateTime(TxtBaslangicTarihi.Text).ToOADate()));
            int bitisTarihi = Convert.ToInt32((Convert.ToDateTime(TxtBitisTarihi.Text).ToOADate()));

            cmd.Parameters.Add(new SqlParameter("@MalKodu", malKodu));
            cmd.Parameters.Add(new SqlParameter("@BaslangicTarihi", baslangicTarihi));
            cmd.Parameters.Add(new SqlParameter("@BitisTarihi", bitisTarihi));
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sd.Fill(dt);


            var stok = 0;

            foreach (DataRow dr in dt.Rows)
            {
                if (dr[3].ToString() == "Giriş")
                    stok += Convert.ToInt32(dr[6]);
                else
                    stok -= Convert.ToInt32(dr[6]);
                dr[6] = stok;
            }
            dataGrid.DataSource = dt;
        }

        private void TxtBaslangicTarihi_EditValueChanged(object sender, EventArgs e)
        {
          
        }
    }
}
