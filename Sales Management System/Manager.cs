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
    public partial class Manager : Form
    {
        String managerName;
        String managerId;
        public Manager(String managerName, String managerId)
        {
            this.managerId = managerId;
            this.managerName = managerName;
            InitializeComponent();
            this.label3.Text = managerName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Announcement_cs announcementObj =new  Announcement_cs(managerId, managerName);
            announcementObj.ShowDialog();
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
            obj.ShowDialog();
           
        }
    }
}
