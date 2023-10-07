using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace arm_net
{
    public partial class comp_add : Form
    {
        DataBase DataBase = new DataBase();

        public comp_add()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void save_Click(object sender, EventArgs e)
        {
            DataBase.openConnection();
            string query = $"INSERT INTO Company (ownship, name_c, itn_c, city, addr, e_mail, phone)\r\n\r\nVALUES ('{ownship.Text}','{name.Text}', '{itn.Text}', '{city.Text}', '{addr.Text}', '{mail.Text}', '{phone.Text}')";
            SqlCommand cmd = new SqlCommand(query, DataBase.getConnection());
            cmd.ExecuteNonQuery();
            DataBase.closeConnection();

            this.Close();
        }
    }
}
