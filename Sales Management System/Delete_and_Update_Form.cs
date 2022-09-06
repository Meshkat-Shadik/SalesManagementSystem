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
    public partial class Delete_and_Update_Form : Form
    {
        String id;
        String name;
        String table;
        String password;
        public Delete_and_Update_Form(String id, String name, String table, String password)
        {
            this.id = id;
            this.name = name;
            this.table = table;
            this.password = password;
            InitializeComponent();
            label2.Text = name;
            textBox1.Text = name;
            textBox2.Text = password;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database dbObj = new Database();
           bool response =  dbObj.updateItems(table, this.textBox1.Text.Trim(), this.textBox2.Text.Trim(), id);
            if(response == true)
            {
                MessageBox.Show("Updated Information for " + name);
                this.Hide();

                if (table.Contains("manager"))
                {
                    Manager_Management obj = new Manager_Management();
                    obj.ShowDialog();
                }
                else
                {
                    Sales_Management obj = new Sales_Management();
                    obj.ShowDialog();
                }
             
            }
            else
            {
                MessageBox.Show("Something error happend!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Database dbObj = new Database();
            bool response = dbObj.deleteItem(table, id);
            
           if (response == true)
            {
                MessageBox.Show("Deleted Information for " + name);
                this.Hide();
                if (table.Contains("manager"))
                {
                    Manager_Management obj = new Manager_Management();
                    obj.ShowDialog();
                }
                else
                {
                    Sales_Management obj = new Sales_Management();
                    obj.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Something error happend!!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
