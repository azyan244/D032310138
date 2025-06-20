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
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\Desktop\\SEM4\\EDP\\LabTest2\\AdmiralBookstoreDatabase.mdf;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Stock", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\Desktop\\SEM4\\EDP\\LabTest2\\AdmiralBookstoreDatabase.mdf;Integrated Security=True";

            if (!int.TryParse(txtBoxStockID.Text.Trim(), out int stockID))
            {
                MessageBox.Show("Invalid Stock ID. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this stock item?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        string deleteQuery = "DELETE FROM Stock WHERE StockID = @StockID";
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@StockID", stockID);
                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            conn.Close();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Stock deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FormStock_Load(null, null); // Refresh the DataGridView
                                txtBoxStockID.Clear(); // Optional: clear input
                            }
                            else
                            {
                                MessageBox.Show("Stock ID not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error while deleting: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnToBook_Click(object sender, EventArgs e)
        {
            FormBook formBook = new FormBook();
            this.Hide();
            formBook.ShowDialog();
            this.Close();
        }

        private void btnToAuthor_Click(object sender, EventArgs e)
        {
            FormAuthor formAuthor = new FormAuthor();
            this.Hide();
            formAuthor.ShowDialog();
            this.Close();
        }
    }
    
}
