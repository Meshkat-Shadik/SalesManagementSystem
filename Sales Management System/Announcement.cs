using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Management_System
{
    public partial class Announcement_cs : Form
    {
        String id;
        String userName;
        public Announcement_cs(String id, String userName)
        {
            this.id = id;
            InitializeComponent();
            Database dbObj1 = new Database();
            DataTable dataTable = dbObj1.managerAndAnnouncement();
            dataGridView1.DataSource = dataTable;
           this.label5.Text = userName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Database dbObj = new Database();
           bool response =  dbObj.makeAnouncement("anouncement", this.textBox1.Text.Trim(), this.dateTimePicker1.Value.ToString("yyyy-MM-dd H:mm:ss"),id);
            if(response == true)
            {
               // Database dbObj1 = new Database();
                DataTable dataTable = dbObj.managerAndAnnouncement();
                dataGridView1.DataSource = dataTable;
                MessageBox.Show("Annonuncement Published Successfully!!");
            }
            else
            {
                MessageBox.Show("Something Error Happened");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String selectedId = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
            DialogResult result = MessageBox.Show("Do you Want to delete this announcement?", "WARNING⚠", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Database dbObj1 = new Database();
                bool response =   dbObj1.deleteItem("anouncement", selectedId);
              
               if(response == true)
                {
                    DataTable dataTable = dbObj1.managerAndAnnouncement();
                    dataGridView1.DataSource = dataTable;
                    MessageBox.Show("Deleted Successfully!!");
                }
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 obj = new Form1();
            obj.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Sales_Management obj = new Sales_Management();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Manager obj = new Manager(userName, id);
            obj.Show();
        }
    }
}
