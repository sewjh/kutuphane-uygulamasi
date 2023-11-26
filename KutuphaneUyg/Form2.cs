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

namespace KutuphaneUyg
{
    public partial class Form2 : Form
    {
        int selectedWithClickID;
        public Form2()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            SqlCommand command = new SqlCommand("select * from tableBooks", SqlConnectionClass.connection);
            SqlConnectionClass.CheckConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void dataGridView1_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            selectedWithClickID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["book_id"].Value);
            selectedID.Text = selectedWithClickID.ToString();
            editID.Text = selectedWithClickID.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("delete from tableBooks where book_id = @bid", SqlConnectionClass.connection);
            command.Parameters.AddWithValue("@bid", selectedID.Text);
            command.ExecuteNonQuery();
            Refresh();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into tableBooks (book_name, book_writer) values (@bname, @bwriter)", SqlConnectionClass.connection);
            command.Parameters.AddWithValue("@bname", bookName.Text);
            command.Parameters.AddWithValue("@bwriter", bookWriter.Text);
            command.ExecuteNonQuery();
            Refresh();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("TRUNCATE TABLE tableBooks", SqlConnectionClass.connection);
            command.ExecuteNonQuery();
            Refresh();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update tableBooks set book_name = @bname, book_writer = @bwriter where book_id = @bid", SqlConnectionClass.connection);
            command.Parameters.AddWithValue("@bname", editName.Text);
            command.Parameters.AddWithValue("@bwriter", editWriter.Text);
            command.Parameters.AddWithValue("@bid", editID.Text);
            command.ExecuteNonQuery();
            Refresh();
        }
    }
}
