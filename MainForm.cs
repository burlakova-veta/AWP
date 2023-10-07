using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace arm_net
{
    public partial class MainForm : Form
    {
        DataBase DataBase = new DataBase();

        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            staff_up_Click(sender, e);
            edit_up_Click(sender, e);
            comp_up_Click(sender, e);
            program_up_Click(sender, e);
            alls_CheckedChanged(sender, e);
        }

        private void password_Click(object sender, EventArgs e)
        {
            password form = new password();
            form.ShowDialog();
        }

        private void staff_add_Click(object sender, EventArgs e)
        {
            staff_add windows = new staff_add();
            DialogResult res = windows.ShowDialog();

            if (res == DialogResult.OK)
            {
                staff_up_Click(sender, e);
            }
        }

        private void staff_edit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            staff_edit windows = new staff_edit(id);
            DialogResult res = windows.ShowDialog();

            if (res == DialogResult.OK)
            {
                staff_up_Click(sender, e);
            }
        }

        private void staff_up_Click(object sender, EventArgs e)
        {
            DataBase.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string query = $"SELECT id_staff as id, surname+' '+names+' '+patronymic as ФИО, post as Должность, depart as Отдел, branch as Филиал, stat as Статус, phone as Телефон, e_mail as Почта FROM Staff S\r\n\r\nINNER JOIN Post P ON P.id_post = S.id_post";
            SqlCommand cmd = new SqlCommand(query, DataBase.getConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            DataBase.closeConnection();
        }

        private void staff_del_Click(object sender, EventArgs e)
        {
            DataBase.openConnection();
            
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            
            var res = MessageBox.Show("Удалить запись?", "Удалить", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string sql = "DELETE FROM Staff WHERE id_staff =" + id;

                SqlCommand cmd = new SqlCommand(sql, DataBase.getConnection());
                cmd.ExecuteNonQuery();

                staff_up_Click(sender, e);
            }

            DataBase.closeConnection();
        }

        private void staff_search_Click(object sender, EventArgs e)
        {
            var searchS = search_staff.Text;

            DataBase.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string query = $"SELECT id_staff as id, surname+' '+names+' '+patronymic as ФИО, post as Должность, depart as Отдел, branch as Филиал, stat as Статус, phone as Телефон, e_mail as Почта FROM Staff S\r\n\r\nINNER JOIN Post P ON P.id_post = S.id_post\r\n\r\nWHERE surname+' '+names+' '+patronymic LIKE '%{searchS}%'";
            SqlCommand cmd = new SqlCommand(query, DataBase.getConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            DataBase.closeConnection();
        }

        private void staff_clean_Click(object sender, EventArgs e)
        {
            search_staff.Text = "";
            staff_up_Click(sender, e);
        }

        private void clean1_Click(object sender, EventArgs e)
        {
            fio.Text = "";
            edit_up_Click(sender, e);
        }

        private void clean2_Click(object sender, EventArgs e)
        {
            study.Text = "";
            edit_up_Click(sender, e);
        }

        private void search_fio_Click(object sender, EventArgs e)
        {
            var searchFIO = fio.Text;

            DataBase.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string query = $"SELECT id, S.id_staff as [ID сотрудника], surname+' '+names+' '+patronymic as ФИО, study as [Программа обучения], S.stat as Статус, doc as Документ, S.doc_n as [Номер документа], S.dates as Дата FROM Study S\r\n\r\nINNER JOIN Agreement A ON A.id_study = S.id_study\r\n\r\nINNER JOIN Staff St ON S.id_staff = St.id_staff\r\n\r\nWHERE surname+' '+names+' '+patronymic LIKE '%{searchFIO}%'";
            SqlCommand cmd = new SqlCommand(query, DataBase.getConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            dataGridView4.DataSource = dt;

            DataBase.closeConnection();
        }

        private void search_study_Click(object sender, EventArgs e)
        {
            var searchSt= study.Text;

            DataBase.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string query = $"SELECT id, id_staff as [ID сотрудника], study as [Программа обучения], stat as Статус, doc as Документ, S.doc_n as [Номер документа], dates as Дата FROM Study S\r\n\r\nINNER JOIN Agreement A ON A.id_study = S.id_study\r\n\r\nWHERE study LIKE '%{searchSt}%'";
            SqlCommand cmd = new SqlCommand(query, DataBase.getConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            dataGridView4.DataSource = dt;

            DataBase.closeConnection();
        }

        private void ed_add_Click(object sender, EventArgs e)
        {
            ed_add windows = new ed_add();
            DialogResult res = windows.ShowDialog();

            if (res == DialogResult.OK)
            {
                edit_up_Click(sender, e);
            }
        }

        private void ed_edit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView4.CurrentRow.Cells[0].Value.ToString());

            ed_edit windows = new ed_edit(id);
            DialogResult res = windows.ShowDialog();

            if (res == DialogResult.OK)
            {
                edit_up_Click(sender, e);
            }
        }

        private void edit_up_Click(object sender, EventArgs e)
        {
            DataBase.openConnection(); 
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string query = $"SELECT id, surname+' '+names+' '+patronymic as ФИО, study as [Пррограмма обучения], S.stat as Статус, doc as Документ, S.doc_n as [Номер документа], S.dates as Дата FROM Study S\r\n\r\nINNER JOIN Agreement A ON A.id_study = S.id_study\r\n\r\nINNER JOIN Staff St ON S.id_staff = St.id_staff";
            SqlCommand cmd = new SqlCommand(query, DataBase.getConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            dataGridView4.DataSource = dt;

            DataBase.closeConnection();
        }

        private void edit_del_Click(object sender, EventArgs e)
        {
            DataBase.openConnection();

            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            var res = MessageBox.Show("Удалить запись?", "Удалить", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string sql = "DELETE FROM Study WHERE ID =" + id;

                SqlCommand cmd = new SqlCommand(sql, DataBase.getConnection());
                cmd.ExecuteNonQuery();

                edit_up_Click(sender, e);
            }

            DataBase.closeConnection();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            DataBase.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string query = $"SELECT id, id_staff as [ID сотрудника], study as [Пррограмма обучения], stat as Статус, doc as Документ, S.doc_n as [Номер документа], dates as Дата FROM Study S\r\n\r\nINNER JOIN Agreement A ON A.id_study = S.id_study\r\n\r\nWHERE stat='Нуждается в обучении'";
            SqlCommand cmd = new SqlCommand(query, DataBase.getConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            dataGridView4.DataSource = dt;

            DataBase.closeConnection();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            DataBase.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string query = $"SELECT id, id_staff as [ID сотрудника], study as [Пррограмма обучения], stat as Статус, doc as Документ, S.doc_n as [Номер документа], dates as Дата FROM Study S\r\n\r\nINNER JOIN Agreement A ON A.id_study = S.id_study\r\n\r\nWHERE stat='На обучении'";
            SqlCommand cmd = new SqlCommand(query, DataBase.getConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            dataGridView4.DataSource = dt;

            DataBase.closeConnection();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            DataBase.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string query = $"SELECT id, id_staff as [ID сотрудника], study as [Пррограмма обучения], stat as Статус, doc as Документ, S.doc_n as [Номер документа], dates as Дата FROM Study S\r\n\r\nINNER JOIN Agreement A ON A.id_study = S.id_study\r\n\r\nWHERE stat='Освоено'";
            SqlCommand cmd = new SqlCommand(query, DataBase.getConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            dataGridView4.DataSource = dt;

            DataBase.closeConnection();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            edit_up_Click(sender, e);
        }

        private void comp_add_Click(object sender, EventArgs e)
        {
            comp_add windows = new comp_add();
            DialogResult res = windows.ShowDialog();

            if (res == DialogResult.OK)
            {
                comp_up_Click(sender, e);
            }
        }

        private void comp_edit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());

            comp_edit windows = new comp_edit(id);
            DialogResult res = windows.ShowDialog();

            if (res == DialogResult.OK)
            {
                comp_up_Click(sender, e);
            }
        }

        private void comp_up_Click(object sender, EventArgs e)
        {
            DataBase.openConnection(); 
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string query = $"SELECT id_comp as id, ownship+' '+name_c as [Наименование организации], city as Город, phone as Телефон, e_mail as Почта FROM Company";
            SqlCommand cmd = new SqlCommand(query, DataBase.getConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            dataGridView2.DataSource = dt;

            DataBase.closeConnection();
        }

        private void comp_del_Click(object sender, EventArgs e)
        {
            DataBase.openConnection();

            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            var res = MessageBox.Show("Удалить запись?", "Удалить", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string sql = "DELETE FROM Company WHERE id_comp =" + id;

                SqlCommand cmd = new SqlCommand(sql, DataBase.getConnection());
                cmd.ExecuteNonQuery();

                comp_up_Click(sender, e);
            }

            DataBase.closeConnection();
        }

        private void program_add_Click(object sender, EventArgs e)
        {
            agree_add windows = new agree_add();
            DialogResult res = windows.ShowDialog();

            if (res == DialogResult.OK)
            {
                program_up_Click(sender, e);
            }
        }

        private void program_edit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView3.CurrentRow.Cells[0].Value.ToString());

            agree_edit windows = new agree_edit(id);
            DialogResult res = windows.ShowDialog();

            if (res == DialogResult.OK)
            {
                program_up_Click(sender, e);
            }
        }

        private void program_up_Click(object sender, EventArgs e)
        {
            DataBase.openConnection(); 
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string query = $"SELECT id_study as id, ownship+' '+name_c as [Наименование организации], study as [Программа обучения], doc_n as Договор, date_start as [Дата заключения], date_end as [Действителен до] FROM Agreement A\r\n\r\nINNER JOIN Company C ON A.id_comp = C.id_comp";
            SqlCommand cmd = new SqlCommand(query, DataBase.getConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            dataGridView3.DataSource = dt;

            DataBase.closeConnection();
        }

        private void program_del_Click(object sender, EventArgs e)
        {
            DataBase.openConnection();

            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            var res = MessageBox.Show("Удалить запись?", "Удалить", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string sql = "DELETE FROM Agreement WHERE id_study =" + id;

                SqlCommand cmd = new SqlCommand(sql, DataBase.getConnection());
                cmd.ExecuteNonQuery();

                program_up_Click(sender, e);
            }

            DataBase.closeConnection();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            auth form = new auth();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void person_CheckedChanged(object sender, EventArgs e)
        {
            DataBase.openConnection();

            string query = $"SELECT cnt FROM Post WHERE post = 'Сотрудник отдела кадров'";
            SqlCommand cmd = new SqlCommand(query, DataBase.getConnection());

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    all.Text = Convert.ToString(reader.GetInt32(0));
                }
            }

            string query1 = $"SELECT COUNT(*) FROM Staff S INNER JOIN Post P ON P.id_post = S.id_post WHERE post = 'Сотрудник отдела кадров' GROUP BY S.id_post";
            SqlCommand cmd1 = new SqlCommand(query1, DataBase.getConnection());

            using (SqlDataReader readers = cmd1.ExecuteReader())
            {
                while (readers.Read())
                {
                    tb1.Text = Convert.ToString(readers.GetInt32(0));
                }
            }

            DataBase.closeConnection();
        }

        private void admin_CheckedChanged(object sender, EventArgs e)
        {
            DataBase.openConnection();

            string query = $"SELECT cnt FROM Post WHERE post = 'Системный администратор'";
            SqlCommand cmd = new SqlCommand(query, DataBase.getConnection());

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    all.Text = Convert.ToString(reader.GetInt32(0));
                }
            }

            string query1 = $"SELECT COUNT(*) FROM Staff S INNER JOIN Post P ON P.id_post = S.id_post WHERE post = 'Системный администратор' GROUP BY S.id_post";
            SqlCommand cmd1 = new SqlCommand(query1, DataBase.getConnection());

            using (SqlDataReader readers = cmd1.ExecuteReader())
            {
                while (readers.Read())
                {
                    tb1.Text = Convert.ToString(readers.GetInt32(0));
                }
            }

            DataBase.closeConnection();
        }

        private void boss_CheckedChanged(object sender, EventArgs e)
        {
            DataBase.openConnection();

            string query = $"SELECT cnt FROM Post WHERE post = 'Руководитель отдела кадров'";
            SqlCommand cmd = new SqlCommand(query, DataBase.getConnection());

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    all.Text = Convert.ToString(reader.GetInt32(0));
                }
            }

            string query1 = $"SELECT COUNT(*) FROM Staff S INNER JOIN Post P ON P.id_post = S.id_post WHERE post = 'Руководитель отдела кадров' GROUP BY S.id_post";
            SqlCommand cmd1 = new SqlCommand(query1, DataBase.getConnection());

            using (SqlDataReader readers = cmd1.ExecuteReader())
            {
                while (readers.Read())
                {
                    tb1.Text = Convert.ToString(readers.GetInt32(0));
                }
            }

            DataBase.closeConnection();
        }

        private void alls_CheckedChanged(object sender, EventArgs e)
        {
            DataBase.openConnection();

            string query = $"SELECT SUM(cnt) FROM Post";
            SqlCommand cmd = new SqlCommand(query, DataBase.getConnection());

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    all.Text = Convert.ToString(reader.GetInt32(0));
                }
            }

            string query1 = $"SELECT COUNT(*) FROM Staff";
            SqlCommand cmd1 = new SqlCommand(query1, DataBase.getConnection());

            using (SqlDataReader readers = cmd1.ExecuteReader())
            {
                while (readers.Read())
                {
                    tb1.Text = Convert.ToString(readers.GetInt32(0));
                }
            }

            DataBase.closeConnection();
        }
    }
}
