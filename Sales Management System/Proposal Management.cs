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
    public partial class Proposal_Management : Form
    {
        String userid;
        String userName;
        public Proposal_Management(String id, String userName)
        {
           
            InitializeComponent();
            this.userid = id;
            this.userName = userName;
            Database dbobj = new Database();
           DataTable db =  dbobj.showData("proposal_management");
            this.dataGridView1.DataSource = db;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            String active_inactive;
            if(this.checkBox1.Enabled == true)
            {
                active_inactive = "active";
            }
            else
            {
                active_inactive = "inactive";
            }

            Database db = new Database();
            db.insertIntoProposal(userid,this.textBox1.Text.Trim(),this.textBox2.Text.Trim(), 
                this.textBox3.Text.Trim(), this.textBox4.Text.Trim(), this.textBox5.Text.Trim(),
                this.textBox6.Text.Trim(),this.textBox7.Text.Trim(), this.textBox8.Text.Trim(), active_inactive);
            DataTable dt = db.showData("proposal_management");
            this.dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String productname = dataGridView1.SelectedRows[0].Cells["product_name"].Value.ToString();
            String budget = dataGridView1.SelectedRows[0].Cells["budget"].Value.ToString();
            String amount = dataGridView1.SelectedRows[0].Cells["amount"].Value.ToString();
            String duration = dataGridView1.SelectedRows[0].Cells["duration"].Value.ToString();
            String contact_name = dataGridView1.SelectedRows[0].Cells["contact_name"].Value.ToString();
            String contact_number = dataGridView1.SelectedRows[0].Cells["contact_number"].Value.ToString();
            String description = dataGridView1.SelectedRows[0].Cells["description"].Value.ToString();
            String rejected_reason = dataGridView1.SelectedRows[0].Cells["rejected_reason"].Value.ToString();
            String status = dataGridView1.SelectedRows[0].Cells["status"].Value.ToString();
            String productId = dataGridView1.SelectedRows[0].Cells["product_id"].Value.ToString();

            bool statusCheckBox;
            if(status.Contains("active"))
            {
                statusCheckBox = true;
            }
            else
            {
                statusCheckBox = false;
            }
             DeleteUpdateProposal obj = new DeleteUpdateProposal(userName,productId, productname,
                budget,
                amount, duration, contact_name,
                contact_number, description, rejected_reason, statusCheckBox);
            this.Close();
            obj.Show();   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 obj = new Form1();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Project obj = new Project(userid,userName);
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Opportutiny_Management obj = new Opportutiny_Management(userid, userName);
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            SALES obj = new SALES(userName,userid);
            obj.Show();
        }
    }
}
