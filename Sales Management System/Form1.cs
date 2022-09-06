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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.comboBox1.Text))
            {
                MessageBox.Show("Please Select a Category");
            }
            else
            {

                String comboBoxValue = this.comboBox1.SelectedItem.ToString();
                if (comboBoxValue.Contains("ADMIN"))
                {
                    String username = this.textBox1.Text.ToString();
                    String password = this.textBox2.Text.ToString();

                    Database dbObj = new Database();
                    String isLoggedIn = dbObj.Login(username, password, "admin");
                
                    if (isLoggedIn != null)
                    {
                        ADMIN adminObj = new ADMIN();
                        adminObj.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                         MessageBox.Show("Username/Password Invalid");
                    }

                }
                else if (comboBoxValue.Contains("MANAGER"))
                {
                    String username2 = this.textBox1.Text.ToString();
                    String password2 = this.textBox2.Text.ToString();

                    Database dbObj = new Database();
                    String id = dbObj.Login(username2, password2, "manager");
                    if (id != null)
                    {
                        Manager managerObj = new Manager(username2,id);
                       managerObj.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        Manager managerObj = new Manager(username2, id);
                        managerObj.ShowDialog();
                      //  MessageBox.Show("Username/Password Invalid");
                    }
               
                }
                else if (comboBoxValue.Contains("SALES"))
                {
                    String username3 = this.textBox1.Text.ToString();
                    String password3 = this.textBox2.Text.ToString();

                    Database dbObj = new Database();
                    String id = dbObj.Login(username3, password3, "sales");
               
                    if (id != null)
                    {
                        SALES salesObj = new SALES(username3,id);
                        salesObj.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username/Password Invalid");
                    }
                  
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
