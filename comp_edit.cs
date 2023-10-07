using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace arm_net
{
    public partial class comp_edit : Form
    {
        DataBase DataBase = new DataBase();

        int id { get; set; }

        public comp_edit(int id_con)
        {
            InitializeComponent();

            id = id_con;
            DataBase.openConnection();

            string editQuery = $"SELECT * FROM Company WHERE id_comp = " + id;
            SqlCommand cmd = new SqlCommand(editQuery, DataBase.getConnection());

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    ownship.Text = reader.GetString(1);
                    name.Text = reader.GetString(2);
                    itn.Text = reader.GetString(3);
                    city.Text = reader.GetString(4);
                    addr.Text = reader.GetString(5);
                    mail.Text = reader.GetString(6);
                    phone.Text = reader.GetString(7);
                }
            }
            DataBase.closeConnection();
        }

        private void save_Click(object sender, EventArgs e)
        {
            DataBase.openConnection();

            string query = $"UPDATE Company\r\n\r\nSET ownship='{ownship.Text}', name_c='{name.Text}', itn_c='{itn.Text}', city='{city.Text}', addr='{addr.Text}', e_mail='{mail.Text}', phone='{phone.Text}'\r\n\r\nWHERE id_comp =" + id;;
            SqlCommand cmd = new SqlCommand(query, DataBase.getConnection());

            cmd.ExecuteNonQuery();
            DataBase.closeConnection();

            this.Close();
        }
    }
}