using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_task
{
    public partial class Employee : Form
    {
        Functions Con;
        public Employee()
        {
            InitializeComponent();
            Con = new Functions();
            ShowEmp();
            GetDepartment();
        }
        private void ShowEmp()
        {
            string Query = "SELECT * FROM Employeetbl";
            Emplist.DataSource = Con.GetData(Query);
        }
        private void GetDepartment() 
        {
            string Query = "select * from Departmenttbl";
            Depcp.DisplayMember = Con.GetData(Query).Columns["Dep_name"].ToString();
            Depcp.ValueMember = Con.GetData(Query).Columns["Depid"].ToString();
            Depcp.DataSource = Con.GetData(Query);
        }
        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            login Obj = new login();
            Obj.Show();
            this.Hide();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Empnametb.Text == "" || Gencp.SelectedIndex == -1 || Depcp.SelectedIndex == -1 || Empdailysaltb.Text == "")
                {
                    MessageBox.Show("Missing data!");
                }
                else
                {
                    string name = Empnametb.Text;
                    string gender = Gencp.SelectedItem.ToString();
                    int dep = Convert.ToInt32(Depcp.SelectedValue.ToString());
                    int salary = Convert.ToInt32(Empdailysaltb.Text);
                    string Jdate = JDtb.Value.ToString("yyyy-MM-dd");
                    string DOB = DOBtb.Value.ToString("yyyy-MM-dd");
                    string Query = "Insert into Employeetbl values('{0}','{1}',{2},'{3}','{4}','{5}')";
                    Query = string.Format(Query, name, gender, dep, DOB, Jdate, salary);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Added!!!!!UWU.");
                    Empnametb.Text = "";
                    Gencp.SelectedIndex = -1;
                    Gencp.SelectedIndex = -1;
                    Empdailysaltb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Empnametb.Text == "" || Gencp.SelectedIndex == -1 || Depcp.SelectedIndex == -1 || Empdailysaltb.Text == "")
                {
                    MessageBox.Show("Missing data!");
                }
                else
                {
                    string name = Empnametb.Text;
                    string gender = Gencp.SelectedItem.ToString();
                    int dep = Convert.ToInt32(Depcp.SelectedValue.ToString());
                    int salary = Convert.ToInt32(Empdailysaltb.Text);
                    string Jdate = JDtb.Value.ToString("yyyy-MM-dd");
                    string DOB = DOBtb.Value.ToString("yyyy-MM-dd");
                    string Query = "Update Employeetbl set Emp_nam = '{0}', Emp_gen = '{1}', Emp_dep = {2}, Emp_ddb = '{3}', Emp_Jdate = '{4}', Empsal = '{5}' where Empid = '{6}'";
                    Query = string.Format(Query, name, gender, dep, DOB, Jdate, salary);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Updated!!!UWU.");
                    Empnametb.Text = "";
                    Gencp.SelectedIndex = -1;
                    Gencp.SelectedIndex = -1;
                    Empdailysaltb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int key = 0;
        private void Emplist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Empnametb.Text = Emplist.SelectedRows[0].Cells[1].Value.ToString();
            if (Empnametb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(Emplist.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}

