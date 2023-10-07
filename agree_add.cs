using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace arm_net
{
    public partial class agree_add : Form
    {
        DataBase DataBase = new DataBase();

        public agree_add()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void save_Click(object sender, EventArgs e)
        {
            DataBase.openConnection();

            string query = $"INSERT INTO Agreement (id_comp, study, doc_n, date_start, date_end)\r\n\r\nVALUES ('{comp.Text}','{study.Text}', '{doc.Text}', '{start.Value}', '{end.Value}')";
            SqlCommand cmd = new SqlCommand(query, DataBase.getConnection());

            cmd.ExecuteNonQuery();
            DataBase.closeConnection();

            this.Close();
        }
    }
}
