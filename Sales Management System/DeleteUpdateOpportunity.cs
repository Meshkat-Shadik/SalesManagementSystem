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
    public partial class DeleteUpdateOpportunity : Form
    {
      

        private void button1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            bool response = db.updateItemFromOpportunity(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, id);
            if(response == true)
            {
                MessageBox.Show("Updated Succesfully!!");
                this.Close();
                Opportutiny_Management obj = new Opportutiny_Management(userId, username);
                obj.Show();
            }
            else
            {
                MessageBox.Show("Something Error Happend!!!");
            }
        }
      

        private void button2_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            bool response = db.deleteItemFromOpportunity(id);
            if(response == true)
            {
                MessageBox.Show("Deleted Succesfully!!");
                this.Close();
                Opportutiny_Management obj = new Opportutiny_Management(userId, username);
                obj.Show();
            }
            else
            {
                MessageBox.Show("Something Error Happend!!!");
            }

        }

        String username,name, date_time, type, chance_to_close, budget, duration, contact_name, contact_number, description, notes, id, userId;

        public DeleteUpdateOpportunity(String username,String name, String date_time, String type, String chance_to_close, String budget, String duration, String contact_name, String contact_number, String description, String notes, String id, String userId)
        {
            this.username = username;
            this.name = name;
            this.date_time = date_time;
            this.type = type;
            this.chance_to_close = chance_to_close;
            this.budget = budget;
            this.duration = duration;
            this.contact_name = contact_name;
            this.contact_number = contact_number;
            this.description = description;
            this.notes = notes;
            this.id = id;
            this.userId = userId;
            InitializeComponent();
      
            textBox1.Text = name;
            textBox2.Text = date_time;
            textBox3.Text = type;
            textBox4.Text = chance_to_close;
            textBox5.Text = budget;
            textBox6.Text = duration;
            textBox7.Text = contact_name;
            textBox8.Text = contact_number;
            textBox9.Text = description;
            textBox10.Text = notes;
        }
    }
}
