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
    public partial class ADMIN : Form
    {
        public ADMIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager_Management manager_ManagementObj = new Manager_Management();
            manager_ManagementObj.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1Obj = new Form1();
            form1Obj.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
