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
    public partial class Manager_Management : Form
    {
        public Manager_Management()
        {
            InitializeComponent();
            Database dbObj1 = new Database();
            DataTable dataTable = dbObj1.showData("manager");
            dataGridView1.DataSource = dataTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Database dbObj = new Database();
           bool returnedValue =  dbObj.insertIntoTable("manager", this.textBox1.Text.ToString(), this.textBox2.Text.ToString());
            if(returnedValue == true)
            {
                DataTable dataTable = dbObj.showData("manager");
                dataGridView1.DataSource = dataTable;
                MessageBox.Show("Manager added!!");
               
            }
            else
            {
                MessageBox.Show("Something Error Happened!!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         String selectedId = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
            String selectedName = dataGridView1.SelectedRows[0].Cells["username"].Value.ToString();
            String selectedPassword = dataGridView1.SelectedRows[0].Cells["password"].Value.ToString();
            Delete_and_Update_Form deleteUpdateFormObj = new Delete_and_Update_Form(selectedId, selectedName, "manager", selectedPassword);
            this.Hide();
            deleteUpdateFormObj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1Obj = new Form1();
            form1Obj.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            ADMIN obj = new ADMIN();
            obj.Show();
        }
    }
}
