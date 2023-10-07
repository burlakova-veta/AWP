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

namespace arm_net
{
    public partial class auth : Form
    {
        DataBase DataBase = new DataBase();
        
        public auth()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void save_Click(object sender, EventArgs e)
        {
            DataBase.openConnection();
            
            var loginUser = login.Text;
            var passUser = password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string query = $"SELECT id_user FROM register WHERE login_user = '{loginUser}' AND pass_user = '{passUser}'";

            SqlCommand cmd = new SqlCommand(query, DataBase.getConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            if(dt.Rows.Count == 1)
            {
                MainForm form = new MainForm();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверно введены данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DataBase.closeConnection();
        }

        private void main_Load(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
            pict_no.Visible = true;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            password.Text = "";
        }

        private void clear_log_Click(object sender, EventArgs e)
        {
            login.Text = "";
        }

        private void pict_yes_Click(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = false;
            pict_yes.Visible = false;
            pict_no.Visible = true;
        }

        private void pict_no_Click(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
            pict_yes.Visible = true;
            pict_no.Visible = false;
        }
    }
}
