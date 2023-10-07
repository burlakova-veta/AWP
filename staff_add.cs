using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace arm_net
{
    public partial class staff_add : Form
    {
        DataBase DataBase = new DataBase();
        
        public staff_add()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void save_Click(object sender, EventArgs e)
        {
            DataBase.openConnection();

            string query = $"INSERT INTO Staff (surname, names, patronymic, passport, nation, sex, city, addr, birthdate, phone, e_mail, id_post, depart, branch, stat, dates, experience, formats, doc_ed, doc_ed_n, qualif, univer, special, years, work_doc, snils, contract_n, itn, military)\r\n\r\nVALUES ('{sur.Text}','{name.Text}', '{patr.Text}', '{passport.Text}', '{rf.SelectedItem}', '{sex.SelectedItem}', '{city.Text}', '{addr.Text}', '{date.Value}', '{phone.Text}', '{mail.Text}', '{Convert.ToInt32(posts.Text)}', '{depart.Text}', '{branch.Text}', '{role.SelectedItem}', '{date2.Value}', '{Convert.ToInt32(exp.Text)}', '{format.SelectedItem}', '{doc.SelectedItem}', '{doc_n.Text}', '{qual.SelectedItem}', '{univer.Text}', '{spec.Text}', '{Convert.ToInt32(year.Text)}', '{work.Text}', '{snils.Text}', '{work_doc.Text}', '{itn.Text}', '{military.Text}')";
            SqlCommand cmd = new SqlCommand(query, DataBase.getConnection());

            cmd.ExecuteNonQuery();
            DataBase.closeConnection();

            this.Close();
        }
    }
}
