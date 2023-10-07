using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace arm_net
{
    public partial class ed_add : Form
    {
        DataBase DataBase = new DataBase();

        public ed_add()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void save_Click(object sender, EventArgs e)
        {
            DataBase.openConnection();

            string query = $"INSERT INTO Study (id_staff, id_study, stat, doc, doc_n, dates)\r\n\r\nVALUES ('{Convert.ToInt32(staff.Text)}','{Convert.ToInt32(study.Text)}', '{stat.SelectedItem}', '{doc.SelectedItem}', '{docn.Text}', '{date.Value}')";
            SqlCommand cmd = new SqlCommand(query, DataBase.getConnection());
            cmd.ExecuteNonQuery();

            DataBase.closeConnection();

            this.Close();
        }
    }
}