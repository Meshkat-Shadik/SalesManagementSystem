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
    public partial class Sales_Management : Form
    {
        String selectedId;
        String selectedName;
        String selectedPassword;
        public Sales_Management()
        {
            InitializeComponent();
            Database dbObj1 = new Database();
            DataTable dataTable = dbObj1.showData("sales");
            this.dataGridView1.DataSource = dataTable;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Database dbObj = new Database();
            bool returnedValue = dbObj.insertIntoTable("sales", this.textBox1.Text.ToString(), this.textBox2.Text.ToString());
            if (returnedValue == true)
            {
                DataTable dataTable = dbObj.showData("sales");
                this.dataGridView1.DataSource = dataTable;
                MessageBox.Show("SalesMan added!!");

            }
            else
            {
                MessageBox.Show("Something Error Happened!!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           selectedId = this.dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
            selectedName = this.dataGridView1.SelectedRows[0].Cells["username"].Value.ToString();
            selectedPassword = this.dataGridView1.SelectedRows[0].Cells["password"].Value.ToString();
            Delete_and_Update_Form deleteUpdateFormObj = new Delete_and_Update_Form(selectedId, selectedName,"sales", selectedPassword);
            this.Hide();
            deleteUpdateFormObj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Announcement_cs obj = new Announcement_cs(selectedId,selectedName);
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 obj = new Form1();
            obj.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Manager obj = new Manager(selectedName,selectedId);
            obj.Show();
        }
    }
}
