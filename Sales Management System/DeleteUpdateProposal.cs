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
    public partial class DeleteUpdateProposal : Form
    {
        String userName;
        String userId;
        String productName;
        String budget;
        String amount;
        String duration;
        String contact_name;
        String contact_number; 
        String description; 
        String rejected_reason; 
        bool status;
        public DeleteUpdateProposal(String userName, String userId, String productName, String budget, String amount, String duration, String contact_name, String contact_number, String description, String rejected_reason,bool status)
        {

            this.userName = userName;
            this.userId = userId;
            this.productName = productName;
            this.budget = budget;
            this.amount = amount;
            this.duration = duration;
            this.contact_name = contact_name;
            this.contact_number = contact_number;
            this.description = description;
            this.rejected_reason = rejected_reason;
            this.status = status;
            InitializeComponent();
            this.textBox1.Text = productName;
            this.textBox2.Text = budget;
            this.textBox3.Text = amount;
            this.textBox4.Text = duration;
            this.textBox5.Text = contact_name;
            this.textBox6.Text = contact_number;
            this.textBox7.Text = description;
            this.textBox8.Text = rejected_reason;
            this.checkBox1.Checked = status;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String statusString;
            if(status == true)
            {
                statusString = "active";
            }
            else
            {
                statusString = "inactive";
            }
            Database dbObj = new Database();
            bool response = dbObj.updateItemFromProposal(this.textBox1.Text, this.textBox2.Text, this.textBox3.Text, this.textBox4.Text, this.textBox5.Text, this.textBox6.Text, this.textBox7.Text, this.textBox8.Text, statusString, userId);
            MessageBox.Show(response.ToString());
             if (response == true)
             {
               MessageBox.Show("Updated Successfully");
               Proposal_Management obj = new Proposal_Management(userId,userName);
                this.Close();
                obj.Show();
                
             }
             else
            {
                MessageBox.Show("Something Error Happened!!");
            }    

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
