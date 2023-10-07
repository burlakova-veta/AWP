using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace arm_net
{
    public partial class agree_edit : Form
    {
        DataBase DataBase = new DataBase();

        int id { get; set; }

        public agree_edit(int id_con)
        {
            InitializeComponent();

            id = id_con;
            DataBase.openConnection();

            string editQuery = $"SELECT * FROM Agreement WHERE id_study = " + id;
            SqlCommand cmd = new SqlCommand(editQuery, DataBase.getConnection());

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    comp.Text = Convert.ToString(reader.GetInt32(1));
                    study.Text = reader.GetString(2);
                    doc.Text = reader.GetString(3);
                    start.Value = reader.GetDateTime(4);
                    end.Value = reader.GetDateTime(5);
                }
            }
            DataBase.closeConnection();
        }

        private void save_Click(object sender, EventArgs e)
        {
            DataBase.openConnection();

            string query = $"UPDATE Agreement\r\n\r\nSET id_comp='{Convert.ToInt32(comp.Text)}', study='{study.Text}', doc_n='{doc.Text}', date_start='{start.Value}', date_end='{end.Value}'\r\n\r\nWHERE id_study =" + id;
            SqlCommand cmd = new SqlCommand(query, DataBase.getConnection());

            cmd.ExecuteNonQuery();
            DataBase.closeConnection();

            this.Close();
        }
    }
}