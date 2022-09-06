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
    public partial class Project : Form
    {
        String username;
        String id;
        public Project(String id, String username)
        {
            InitializeComponent();
            this.id = id;
            this.username = username;
            displayGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void displayGridView()
        {
            Database obj = new Database();
            DataTable dt = obj.showProject(id);
            this.dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String statusString;
            if(checkBox1.Checked)
            {
                statusString = "active";
            }
            else
            {
                statusString = "inactive";
            }


            Database obj = new Database();
           bool response = obj.insertIntoProject(id,textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text.Trim(), textBox4.Text.Trim(), this.dateTimePicker1.Value.ToString("yyyy-MM-dd H:mm:ss"), textBox6.Text.Trim(), textBox7.Text.Trim(), textBox8.Text.Trim(), textBox9.Text.Trim(), statusString);

          
             if(response == true)
            {
                displayGridView();
                MessageBox.Show("Project added Successfully!!");
               
            }
            else
            {
                MessageBox.Show("Something error happend!!");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 obj = new Form1();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Proposal_Management obj = new Proposal_Management(id,username);
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Proposal_Management obj = new Proposal_Management(id,username);
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Project obj = new Project(id,username);
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            SALES obj = new SALES(id, username);
            obj.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            String productname = dataGridView1.SelectedRows[0].Cells["name"].Value.ToString();
            String amount = dataGridView1.SelectedRows[0].Cells["amount"].Value.ToString();
            String revenue = dataGridView1.SelectedRows[0].Cells["revanue"].Value.ToString();
            String description = dataGridView1.SelectedRows[0].Cells["description"].Value.ToString();
            String status = dataGridView1.SelectedRows[0].Cells["status"].Value.ToString();
            String duration = dataGridView1.SelectedRows[0].Cells["duration"].Value.ToString();
            String contactname = dataGridView1.SelectedRows[0].Cells["contactname"].Value.ToString();
            String contactmobile = dataGridView1.SelectedRows[0].Cells["contact mobile"].Value.ToString();
            String notes = dataGridView1.SelectedRows[0].Cells["notes"].Value.ToString();
            String productId = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
            String userId = dataGridView1.SelectedRows[0].Cells["user_id"].Value.ToString();
            this.Close();
            DeleteUpdateProject obj = new DeleteUpdateProject(productname,amount, revenue,description,status,duration,contactname,contactmobile,notes,productId,userId);
            obj.Show();

        }
    }
}
