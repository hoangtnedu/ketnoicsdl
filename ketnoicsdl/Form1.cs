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

namespace ketnoicsdl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnectbyWindows_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString= @"Data Source = DESKTOP-BF9480B; Initial Catalog =QLSV;User Id =hoangtn1204; Password = 123";
            try
            {
                Conn.Open();
                lblThongbao.Text = "Kết nối thành công";
            }
            catch (Exception ex)
            {

                lblThongbao.Text = "Kết nối thất bại"+ex.ToString();
            }

        }
    }
}
