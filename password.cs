using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace arm_net
{
    public partial class password : Form
    {
        DataBase DataBase = new DataBase();

        public static bool UseSystemPasswordChar { get; private set; }

        public password()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void save_Click(object sender, EventArgs e)
        {
            DataBase.openConnection();

            var passOld = old.Text;
            var passNew1 = new1.Text;
            var passNew2 = new2.Text;

            if (passNew1 == passNew2) {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dt = new DataTable();

                string query = $"UPDATE register\r\n\r\nSET pass_User='{passNew1}'";

                SqlCommand cmd = new SqlCommand(query, DataBase.getConnection());

                adapter.SelectCommand = cmd;
                adapter.Fill(dt);

                DataBase.closeConnection();
                this.Close();
            }
        }

        private void no1_Click(object sender, EventArgs e)
        {
            old.UseSystemPasswordChar = true;
            yes1.Visible = true;
            no1.Visible = false;
        }

        private void no2_Click(object sender, EventArgs e)
        {
            new1.UseSystemPasswordChar = true;
            yes2.Visible = true;
            no2.Visible = false;
        }

        private void no3_Click(object sender, EventArgs e)
        {
            new2.UseSystemPasswordChar = true;
            yes3.Visible = true;
            no3.Visible = false;
        }

        private void yes1_Click(object sender, EventArgs e)
        {
            old.UseSystemPasswordChar = false;
            yes1.Visible = false;
            no1.Visible = true;
        }

        private void yes2_Click(object sender, EventArgs e)
        {
            new1.UseSystemPasswordChar = false;
            yes2.Visible = false;
            no2.Visible = true;
        }

        private void yes3_Click(object sender, EventArgs e)
        {
            new2.UseSystemPasswordChar = false;
            yes3.Visible = false;
            no3.Visible = true;
        }

        private void password_Load(object sender, EventArgs e)
        {
            old.UseSystemPasswordChar = true;
            new1.UseSystemPasswordChar = true;
            new2.UseSystemPasswordChar = true;
            no1.Visible = false;
            no2.Visible = false;
            no3.Visible = false;
            yes1.Visible = true;
            yes2.Visible = true;
            yes3.Visible = true;
        }
    }
}