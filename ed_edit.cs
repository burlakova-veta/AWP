using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace arm_net
{
    public partial class ed_edit : Form
    {
        DataBase DataBase = new DataBase();

        int id { get; set; }

        public ed_edit(int id_con)
        {
            InitializeComponent();

            id = id_con;
            DataBase.openConnection();

            string editQuery = $"SELECT * FROM Study WHERE id = " + id;
            SqlCommand cmd = new SqlCommand(editQuery, DataBase.getConnection());

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    staff.Text = Convert.ToString(reader.GetInt32(1));
                    study.Text = Convert.ToString(reader.GetInt32(2));
                    stat.SelectedItem = reader.GetString(3);
                    doc.SelectedItem = reader.GetString(4);
                    docn.Text = reader.GetString(5);
                    date.Value = reader.GetDateTime(6);
                }
            }
            DataBase.closeConnection();
        }

        private void save_Click(object sender, EventArgs e)
        {
            DataBase.openConnection();

            string query = $"UPDATE Study\r\n\r\nSET id_staff='{staff.Text}', id_study='{study.Text}', stat='{stat.SelectedItem}', doc='{doc.SelectedItem}', doc_n='{docn.Text}', dates='{date.Value}'\r\n\r\nWHERE id =" + id; ;
            SqlCommand cmd = new SqlCommand(query, DataBase.getConnection());

            cmd.ExecuteNonQuery();
            DataBase.closeConnection();

            this.Close();
        }
    }
}