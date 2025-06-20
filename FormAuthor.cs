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
    public partial class FormAuthor : Form
    {
        public FormAuthor()
        {
            InitializeComponent();
        }

        private void FormAuthor_Load(object sender, EventArgs e)
        {
            LoadAuthorData();

        }

        private void btnToBook_Click(object sender, EventArgs e)
        {
            FormBook formBook = new FormBook();
            this.Hide();
            formBook.ShowDialog();
            this.Close();
        }

        private void btnToStock_Click(object sender, EventArgs e)
        {
            FormStock formStock = new FormStock();  
            this.Hide();
            formStock.ShowDialog();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\Desktop\\SEM4\\EDP\\LabTest2\\AdmiralBookstoreDatabase.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO Author (AuthorID, Name, BirthYear) VALUES (@id, @name, @birthday)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", txtBoxAuthorID.Text.Trim());
                        cmd.Parameters.AddWithValue("@name", txtBoxName.Text.Trim());
                        cmd.Parameters.AddWithValue("@birthday", txtBoxBirthYear.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Author added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAuthorData(); // reload DataGridView
                            txtBoxAuthorID.Clear();
                            txtBoxName.Clear();
                            txtBoxBirthYear.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add author.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoadAuthorData()
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\Desktop\\SEM4\\EDP\\LabTest2\\AdmiralBookstoreDatabase.mdf;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Author", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
