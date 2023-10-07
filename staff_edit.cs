using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace arm_net
{
    public partial class staff_edit : Form
    {
        DataBase DataBase = new DataBase();

        int id { get; set; }
        
        public staff_edit(int id_con)
        {
            InitializeComponent();

            id = id_con;
            DataBase.openConnection();

            string editQuery = $"SELECT * FROM Staff WHERE id_staff = " + id;
            SqlCommand cmd = new SqlCommand(editQuery, DataBase.getConnection());

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    sur.Text = reader.GetString(1);
                    name.Text = reader.GetString(2);
                    patr.Text = reader.GetString(3);    
                    passport.Text = reader.GetString(4);
                    rf.SelectedItem = reader.GetString(5);
                    sex.SelectedItem = reader.GetString(6);
                    city.Text = reader.GetString(7);
                    addr.Text = reader.GetString(8);
                    date.Value = reader.GetDateTime(9);
                    phone.Text = reader.GetString(10);
                    mail.Text = reader.GetString(11);
                    post.Text = Convert.ToString(reader.GetInt32(12));
                    depart.Text = reader.GetString(13);
                    branch.Text = reader.GetString(14);
                    role.SelectedItem = reader.GetString(15);
                    date2.Value = reader.GetDateTime(16);
                    exp.Text = Convert.ToString(reader.GetInt32(17));
                    format.SelectedItem = reader.GetString(18);
                    doc.SelectedItem = reader.GetString(19);
                    doc_n.Text = reader.GetString(20);
                    qual.SelectedItem = reader.GetString(21);
                    univer.Text = reader.GetString(22);
                    spec.Text = reader.GetString(23);
                    year.Text = Convert.ToString(reader.GetInt32(24));
                    work.Text = reader.GetString(25);
                    snils.Text = reader.GetString(26);
                    work_doc.Text = reader.GetString(27);
                    itn.Text = reader.GetString(28);
                    military.Text = reader.GetString(29);
                }
            }
            DataBase.closeConnection();
        }

        private void save_Click(object sender, EventArgs e)
        {
            DataBase.openConnection();

            string query = $"UPDATE Staff\r\n\r\nSET surname='{sur.Text}', names='{name.Text}', patronymic='{patr.Text}', passport='{passport.Text}', nation='{rf.SelectedItem}', sex='{sex.SelectedItem}', city='{city.Text}', addr='{addr.Text}', birthdate='{date.Value}', phone='{phone.Text}', e_mail='{mail.Text}', id_post='{Convert.ToInt32(post.Text)}', depart='{depart.Text}', branch='{branch.Text}', stat='{role.SelectedItem}', dates='{date2.Value}', experience='{Convert.ToInt32(exp.Text)}', formats='{format.SelectedItem}', doc_ed='{doc.SelectedItem}', doc_ed_n='{doc_n.Text}', qualif='{qual.SelectedItem}', univer='{univer.Text}', special='{spec.Text}', years='{Convert.ToInt32(year.Text)}', work_doc='{work.Text}', snils='{snils.Text}', contract_n='{work_doc.Text}', itn='{itn.Text}', military='{military.Text}'\r\n\r\nWHERE id_staff =" + id;
            SqlCommand cmd = new SqlCommand(query, DataBase.getConnection());

            cmd.ExecuteNonQuery();
            DataBase.closeConnection();

            this.Close();
        }
    }
}