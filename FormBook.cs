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

namespace LabTest2
{
    public partial class FormBook : Form
    {
        public FormBook()
        {
            InitializeComponent();
        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\Desktop\\SEM4\\EDP\\LabTest2\\AdmiralBookstoreDatabase.mdf;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Book", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }

        private void btnToAuthor_Click(object sender, EventArgs e)
        {
            FormAuthor formAuthor = new FormAuthor();
            this.Hide();
            formAuthor.ShowDialog();
            this.Close();
        }

        private void btnToStock_Click(object sender, EventArgs e)
        {
            FormStock formStock = new FormStock();
            this.Hide();
            formStock.ShowDialog();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxISBN.Text))
            {
                MessageBox.Show("Please select a book to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\Desktop\\SEM4\\EDP\\LabTest2\\AdmiralBookstoreDatabase.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string updateQuery = "UPDATE Book SET Title = @title, Publisher = @publisher, PublishDate = @date WHERE ISBN_13 = @isbn";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@isbn", txtBoxISBN.Text.Trim());
                        cmd.Parameters.AddWithValue("@title", txtBoxTitle.Text.Trim());
                        cmd.Parameters.AddWithValue("@publisher", txtBoxPublisher.Text.Trim());
                        cmd.Parameters.AddWithValue("@date", dateTimePickerPublishDate.Value.Date);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadBookData(); // Refresh table
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Book not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void LoadBookData()
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\Desktop\\SEM4\\EDP\\LabTest2\\AdmiralBookstoreDatabase.mdf;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Book", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
