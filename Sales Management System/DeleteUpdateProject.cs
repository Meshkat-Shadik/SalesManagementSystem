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
    public partial class DeleteUpdateProject : Form
    {
        String name, amount,  revanue,  description,  status,  duration,  contactname,  contactmobile,  notes,  id, statusString, userId;

        private void button2_Click(object sender, EventArgs e)
        {
            Database obj = new Database();
            bool reponse = obj.deleteItemFromProject(id);
            if(reponse == true)
            {
                MessageBox.Show("Successfully Deleted!!");
            }
            else
            {
                MessageBox.Show("Something Error Happend !!");
            }
        }

        bool statusBool;
        public DeleteUpdateProject(String name, String amount, String revanue, String description, String status,String duration, String contactname, String contactmobile, String notes, String id, String userId)
        {
            InitializeComponent();
            this.name = name;
            this.amount = amount;
            this.revanue = revanue;
            this.description = description;
            this.status = status;
            this.duration = duration;
            this.contactname = contactname;
            this.contactmobile = contactmobile;
            this.notes = notes;
            this.id = id;
            this.userId = userId;

            if(status.Contains("active"))
            {
                this.checkBox1.Enabled = true;
            }
            else
            {
                this.checkBox1.Enabled = false;
            }

            this.textBox1.Text = name;
            this.textBox2.Text = amount;
            this.textBox3.Text = revanue;
            this.textBox4.Text = description;
            this.textBox5.Text = duration;
            this.textBox6.Text = contactname;
            this.textBox7.Text = contactmobile;
            this.textBox8.Text = notes;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Enabled == true)
            {
                statusString = "active";
            }
            else
            {
                statusString = "inactive";
            }
            Database db = new Database();
            bool response = db.updateProject(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,statusString,textBox5.Text,textBox6.Text, textBox7.Text, textBox8.Text,id);
            if(response == true)
            {
                MessageBox.Show("Successfully updated!!!");
                this.Close();
                Project obj = new Project(userId,contactname);
                obj.Show();
            }
            else
            {
                MessageBox.Show("Something Error Happend!!!!");
            }
        }
    }
}
