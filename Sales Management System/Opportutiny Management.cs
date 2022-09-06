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
    public partial class Opportutiny_Management : Form
    {
        String id;
        String username;
        public Opportutiny_Management(String id, String username)
        {
            InitializeComponent();
            this.id = id;
            this.username = username;
            display();
         
        }

      public void display()
        {
            Database db = new Database();
            DataTable dt = db.showOpportunityTable(id);
            dataGridView1.DataSource = dt;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 obj = new Form1();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Database db = new Database();
          bool response =  db.opportunityInsert(id, textBox1.Text.Trim(), this.dateTimePicker1.Value.ToString("yyyy-MM-dd H:mm:ss"), textBox2.Text.Trim(), textBox3.Text.Trim(), textBox4.Text.Trim(), textBox5.Text.Trim(), textBox6.Text.Trim(), textBox7.Text.Trim(), textBox8.Text.Trim(), textBox9.Text.Trim());
            if(response == true)
            {
                MessageBox.Show("Inserted Successfully");
                display();
            }
            else
            {
                MessageBox.Show("Something Error Happened!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Proposal_Management obj = new Proposal_Management(id, username);
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Project obj = new Project(id, username);
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            SALES obj = new SALES(username,id);
            obj.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String name = dataGridView1.SelectedRows[0].Cells["name"].Value.ToString();
            String date_time = dataGridView1.SelectedRows[0].Cells["date_time"].Value.ToString();
            String type = dataGridView1.SelectedRows[0].Cells["type"].Value.ToString();
            String chance_to_close = dataGridView1.SelectedRows[0].Cells["chance_to_close"].Value.ToString();
            String budget = dataGridView1.SelectedRows[0].Cells["budget"].Value.ToString();
            String duration = dataGridView1.SelectedRows[0].Cells["duration"].Value.ToString();
            String contact_name = dataGridView1.SelectedRows[0].Cells["contact_name"].Value.ToString();
            String contact_number = dataGridView1.SelectedRows[0].Cells["contact_number"].Value.ToString();
            String description = dataGridView1.SelectedRows[0].Cells["description"].Value.ToString();
            String notes = dataGridView1.SelectedRows[0].Cells["notes"].Value.ToString();
            String user_id = dataGridView1.SelectedRows[0].Cells["user_id"].Value.ToString();
            String main_id = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();

            this.Close();
            DeleteUpdateOpportunity obj = new DeleteUpdateOpportunity(username,name, date_time,type,chance_to_close,budget,duration,contact_name,contact_number,description,notes,main_id,user_id);
            obj.Show();
        }

        private void Opportutiny_Management_Load(object sender, EventArgs e)
        {

        }
    }
}
