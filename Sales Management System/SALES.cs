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
    public partial class SALES : Form
    {
        String announcement;
        String username;
        String id;
        public SALES(String username, String id)
        {
            this.username = username;
            this.id = id;
            InitializeComponent();
            Database db = new Database();
            announcement = db.showAnnouncement();
            label3.Text = announcement;
            label5.Text = username;
            label6.Text = username;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Project obj = new Project(id,username);
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 obj = new Form1();
            obj.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Opportutiny_Management obj = new Opportutiny_Management(id,username);
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Proposal_Management obj = new Proposal_Management(id,username);
            obj.Show();
        }
    }
}
